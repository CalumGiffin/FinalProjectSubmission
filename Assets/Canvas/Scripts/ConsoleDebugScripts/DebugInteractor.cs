using UnityEngine;

public class TipInteractorDebug : MonoBehaviour
{
    void Update()
    {
        //Draws line in scene to show raycast position
        Debug.DrawRay(transform.position, transform.up * 0.2f, Color.green);

        if (Time.frameCount % 60 == 0)
        {
            Debug.Log("Interactor Position: " + transform.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER with: " + other.name);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION with: " + collision.gameObject.name);
    }
}