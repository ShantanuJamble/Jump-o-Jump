using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject player;
    public Camera camera;
    public GameObject endscreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isEnded())
        {
            PauseMenu.paused = true;
            endscreen.SetActive(true);
            Invoke("Restart", 1f);
        }
        
    }

    bool isEnded()
    {
        if (player.transform.position.y < camera.transform.position.y - 10)
        {
            Debug.Log("You're done");
            return true;
        }
        return false;
    }
    void Restart()
    {
        //Need to add logic to give game over message. and move back to main menu not restat the game.
        
         SceneManager.LoadScene(0);
    }
}
