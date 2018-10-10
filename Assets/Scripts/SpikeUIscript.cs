using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeUIscript:MonoBehaviour {
    public GameObject spikehitui_obj;
    public static GameObject spikehitui;
    private void Start()
    {
        spikehitui = spikehitui_obj;
    }
    public static void showhitui()
    {
        spikehitui.SetActive(true);
    }
	
}
