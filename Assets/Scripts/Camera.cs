using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Smoothness of camera movement
    public Vector3 offset; // Offset between the camera and the player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ///followplayer
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;
        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Update the camera's position
        transform.position = smoothedPosition;
        // Make the camera look at the player
        //transform.LookAt(target);


        //transform.position = target.transform.position + new Vector3(0, 1, -5);
        //transform.position = target.transform.position + offset;
    }
}
