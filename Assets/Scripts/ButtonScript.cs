using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public void pause()
    {
        Debug.Log("In pause");
        Time.timeScale = 0;
    }


}
