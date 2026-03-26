using UnityEngine;
using UnityEngine.XR;

public class RobotPenGrabber : MonoBehaviour
{
    public Transform penGrabPoint;
    public float grabRange = 0.1f;

    private InputDevice device;
    private Pen currentPen;

    void Start()
    {
        device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void Update()
    {
        HandleGrab();
    }

    //Grab handler for trigger input
    void HandleGrab()
    {
        if (!device.isValid) return;

        bool triggerPressed;
        device.TryGetFeatureValue(CommonUsages.triggerButton, out triggerPressed);

        //if trigger pressed and not holding a pen try to grab one or release 
        if (triggerPressed)
        {
            if (currentPen == null)
                TryGrabPen();
        }
        else
        {
            if (currentPen != null)
                ReleasePen();
        }
    }

    //checks for pen objects within reach of grab transform and trys to grab it
    void TryGrabPen()
    {
        Collider[] hits = Physics.OverlapSphere(penGrabPoint.position, grabRange);

        foreach (var hit in hits)
        {
            Pen pen = hit.GetComponent<Pen>();
            if (pen != null)
            {
                AttachPen(pen);
                break;
            }
        }
    }

    //Handles position of pen upon grab interaction, snapping it to the defined grab point
    void AttachPen(Pen pen)
    {
        currentPen = pen;

        Rigidbody rb = pen.GetComponent<Rigidbody>();
        if (rb != null)
            rb.isKinematic = true;

        pen.transform.SetParent(penGrabPoint);
        pen.transform.localPosition = Vector3.zero;
        pen.transform.localRotation = Quaternion.identity;
    }

    //releases pen from grabpoint
    void ReleasePen()
    {
        Rigidbody rb = currentPen.GetComponent<Rigidbody>();
        if (rb != null)
            rb.isKinematic = false;

        currentPen.transform.SetParent(null);
        currentPen = null;
    }
}