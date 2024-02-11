using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    //TODO: loading screen
    public Map map;
    public Player1 player1;

    // Start is called before the first frame update
    void Start()
    {
        //todo: initialize map here instead and use loading logic
        map.GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
