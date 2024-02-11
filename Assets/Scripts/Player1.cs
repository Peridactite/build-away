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
        // Calculate the center position of the map
        Vector3 centerPosition = new Vector3(map.mapWidth / 2 * map.tileSize, map.tileSize / 2, map.mapHeight / 2 * map.tileSize);
        transform.position = centerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
