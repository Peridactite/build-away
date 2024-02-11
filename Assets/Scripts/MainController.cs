using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject floorTilePrefab; // Reference to the floor tile prefab
    public int mapWidth = 10; // Width of the map
    public int mapHeight = 10; // Height of the map
    public float tileSize = 1.0f; // Size of each tile


    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateMap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                Vector3 tilePosition = new Vector3(x * tileSize, 0, y * tileSize); // Calculate position for the tile
                GameObject tile = Instantiate(floorTilePrefab, tilePosition, Quaternion.identity); // Instantiate the tile
                // Optionally, you can parent the tile to a container object for better organization
                tile.transform.parent = transform;
            }
        }
    }
}
