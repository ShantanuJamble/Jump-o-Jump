using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject[] platformPrefabs = new GameObject[5];
    public int platformcount = 200;
    int platoformtypescount = 5;
    float max_x = 3f;
    float min_y = 0.5f, max_y = 2f;
	// Update is called once per frame
	void Start () {
        Vector3 spawnpoint = new Vector3();
        int platformselector = 0;
		for(int i = 0; i < platformcount; i++)
        {
            spawnpoint.x = Random.Range(-max_x, max_x);
            spawnpoint.y += Random.Range(min_y, max_y);
            
            if(spawnpoint.y<=20)
            {
                platformselector = Random.Range(0,3);
            }
            else
            {
                platformselector = Random.Range(0, platoformtypescount);
            }
            Instantiate(platformPrefabs[platformselector], spawnpoint, Quaternion.identity);

        }
	}
}
