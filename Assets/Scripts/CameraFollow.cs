using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    // Update is called once per frame
    void LateUpdate() {
        if (!PauseMenu.paused)
        {
            Vector3 tmp = transform.position;
            tmp.y += 0.03F;
            transform.position = tmp;// new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }
   

    
}
