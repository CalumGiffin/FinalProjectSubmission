using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.IO;

public class SaveScript : MonoBehaviour
{
    Canvas canvasScript;
    InputDevice rightController;
    bool lastPressed;

    //Initialize canvas object passed to script and controller
    void Start()
    {
        canvasScript = GetComponent<Canvas>();
        GetController();
    }

    void Update()
    {
        if (!rightController.isValid) GetController();
    //Primary Button for right hand controller is A
        if (rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool pressed))
        {
            //Trigger save if A button pressed this frame
            if (pressed && !lastPressed) SaveTexture();
            lastPressed = pressed;
        }
    }

    //Assigns right hand controller
    void GetController()
    {
        var devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);
        if (devices.Count > 0) rightController = devices[0];
    }

    //Function to save current texture of canvas 
    void SaveTexture()
    {
        if (!canvasScript?.texture) return;

        var bytes = canvasScript.texture.EncodeToPNG();
        var path = Path.Combine(
            Application.persistentDataPath,
            $"SavedImage_{System.DateTime.Now:yyyyMMdd_HHmmss}.png"
        );

        File.WriteAllBytes(path, bytes);
        Debug.Log(path);
    }
}