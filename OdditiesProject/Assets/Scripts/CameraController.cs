using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float smoothness = 0.5f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        //use lerp function to make camera movement smoother (also why done in late update)
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);
    }
}
