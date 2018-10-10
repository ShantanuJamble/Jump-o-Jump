using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGenerator : MonoBehaviour {

    public GameObject[] platformPrefabs = new GameObject[5];
    //public int platformcount = 200;
    public Rigidbody2D player;
    int platoformtypescount = 11;
    float max_x = 3f;
    float min_y = 0.6f, max_y = 2f;
    float current_y;
    
	// Update is called once per frame
	void Start () {
        generateLevel(10); 
	}
    void Update()
    {
        if (player.position.y > current_y - 5f)
        { 
            Debug.Log("Generating new platforms");
            generateLevel(10);

        }    
    }
   
    void generateLevel(int platformcount)
    {
        Vector3 spawnpoint = new Vector3();
        spawnpoint.y = current_y;
        int platformselector = 0;
        int lastchoice = -1;
        for (int i = 0; i < platformcount; i++)
        {
            spawnpoint.x = Random.Range(-max_x, max_x);
            spawnpoint.y += Random.Range(min_y, max_y);
            while (platformselector == lastchoice)
            {
                if (spawnpoint.y <= 20)
                {
                    platformselector = Random.Range(0, 9);
                }
                else
                {
                    platformselector = Random.Range(0, platoformtypescount);
                }
                
            }
            Instantiate(platformPrefabs[platformselector], spawnpoint, Quaternion.identity);
            current_y = spawnpoint.y+0.3f;
            lastchoice = platformselector;

        }
    }
}
