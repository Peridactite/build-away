using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    public GameObject floorTilePrefab; // Reference to the floor tile prefab
    public int mapWidth = 10; // Width of the map
    public int mapHeight = 10; // Height of the map
    public float tileSize = 1.0f; // Size of each tile
    public float minBrightness = 0.5f; // Minimum brightness for the grey tiles
    public float maxBrightness = 0.9f; // Maximum brightness for the grey tiles

    public GameObject woodPrefab; // Reference to the wood node prefab
    public GameObject stonePrefab; // Reference to the stone node prefab
    public GameObject ratNestPrefab; // Reference to the ratNestPrefab
    public GameObject flintPrefab; // Reference to the flintPrefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateMap()
    {
        GameObject[] resourceNodePrefabs = { woodPrefab, stonePrefab, ratNestPrefab, flintPrefab };// Create an array of resource node prefabs
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                ///GENERATE FLOOR///
                // Calculate position for the tile
                Vector3 tilePosition = new Vector3(x * tileSize, 0, y * tileSize);

                // Calculate brightness for green color
                float brightness = Random.Range(minBrightness, maxBrightness);

                // Create color based on brightness
                Color tileColor = new Color(0, brightness, 0); // Green color with varying brightness

                // Create the tile
                GameObject tile = Instantiate(floorTilePrefab, tilePosition, Quaternion.identity);
                tile.GetComponent<Renderer>().material.color = tileColor;

                tile.transform.parent = transform; //parent the tile to a container object for better organization
                // Scale the tile instance based on the tileSize
                tile.transform.localScale = new Vector3(tileSize, 1f, tileSize);

                ///GENERATE RESOURCES///
                // Check if a resource should be generated on this tile
                if (Random.value < 0.1f) // Adjust the probability as needed
                {
                    // Generate a resource node one level above the floor tile
                    Vector3 nodePosition = tilePosition + Vector3.up; // One level above the tile
                    GameObject resourceNodePrefab = resourceNodePrefabs[Random.Range(0, resourceNodePrefabs.Length)]; // Get a random resource node from array
                    GameObject resourceInstance = Instantiate(resourceNodePrefab, nodePosition, Quaternion.identity);
                    resourceInstance.transform.parent = transform; //parent resource to map object
                }
            }
        }
    }
}
