using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer(Map map)
    {
        // Calculate the center position of the map
        Vector3 centerPosition = new Vector3(map.mapWidth / 2 * map.tileSize, 0, map.mapHeight / 2 * map.tileSize);

        // Instantiate the player prefab at the center position
        Instantiate(playerPrefab, centerPosition, Quaternion.identity);
    }
}
