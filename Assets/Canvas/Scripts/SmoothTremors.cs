using UnityEngine;

public class TremorSmoothing : MonoBehaviour
{
    public Transform controller;
    //Time limit for movement of the arm to catch up with the controller
    public float timeLimit = 0.03f; 
    //Speeds limiter to prevent large jumps in movement due to tremors
    public float speedCap = 8f;
    //Speed limiter to prevent erratic wrist movements affecting rotation
    public float rotationSpeed = 10f;

    private Vector3 velocity;

    //Uses the smoothdamp function to move position to target in a slower but smoother motion rather than snapping
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            controller.position,
            ref velocity,
            timeLimit,
            speedCap
        );
    //blends current rotation value and the rotation of the controller to help mitigate tremors in the wrist
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            controller.rotation,
            Time.deltaTime * rotationSpeed
        );
    }
}