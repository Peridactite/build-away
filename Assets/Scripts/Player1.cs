using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public GameObject playerPrefab;
    public Map map;
    public float moveSpeed = 5f; // Speed of player movement

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the center position of the map and place center there
        Vector3 centerPosition = new Vector3(map.mapWidth / 2 * map.tileSize, map.tileSize / 2, map.mapHeight / 2 * map.tileSize);
        transform.position = centerPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouseMovement();
        //WasdMovement();
    }

    void FollowMouseMovement()
    {
        // Check if the left mouse button is pressed down
        if (Input.GetMouseButton(0))
        {
            // Get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;

            // Convert the mouse position to world space
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.transform.position.y));

            // Ignore the y-component of the target position
            targetPosition.y = transform.position.y;

            // Calculate movement direction towards the mouse position
            Vector3 movementDirection = (targetPosition - transform.position).normalized;

            // Move the player towards the mouse position
            transform.position += movementDirection * moveSpeed * Time.deltaTime;
        }
    }

    void WasdMovement()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);

    }
}
