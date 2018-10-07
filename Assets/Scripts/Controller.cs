using UnityEngine;
public class Controller  {

	

	// Update is called once per frame
	 public static float getUserInput () {
        return Input.GetAxis("Horizontal");
		
	}
}
