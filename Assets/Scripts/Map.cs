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
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                // Calculate position for the tile
                Vector3 tilePosition = new Vector3(x * tileSize, 0, y * tileSize);

                // Calculate brightness for green color
                float brightness = Random.Range(minBrightness, maxBrightness);

                // Create color based on brightness
                Color tileColor = new Color(0, brightness, 0); // Green color with varying brightness

                // Create the tile
                GameObject tile = Instantiate(floorTilePrefab, tilePosition, Quaternion.identity);
                tile.GetComponent<Renderer>().material.color = tileColor;

                // Optionally, you can parent the tile to a container object for better organization
                tile.transform.parent = transform; //TODO try turning this off and see how it effects object heirarchy B) Map should probably have its own gameobject and script. 

                // Scale the tile instance based on the tileSize
                tile.transform.localScale = new Vector3(tileSize, 1f, tileSize);
            }
        }
    }
}
