using UnityEngine;

public class FollowTip : MonoBehaviour
{
    public Transform tip;

    void LateUpdate()
    {
        if (tip == null)
        {
            Debug.LogError("Tip not assigned!");
            return;
        }

        transform.position = tip.position;
        transform.rotation = tip.rotation;
    }
}