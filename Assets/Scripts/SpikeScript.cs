using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You hit a spike");
        Invoke("Restart", 1f);
    }
    void Restart()
    {
        //Need to add logic to give game over message. and move back to main menu not restat the game.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
