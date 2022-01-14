using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;

    void Update()
    {
        this.transform.position = player.position + cameraOffset;
    }
}
