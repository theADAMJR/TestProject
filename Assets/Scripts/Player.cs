using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Prints input on horizontal axis
        Debug.Log("V: " + CrossPlatformInputManager.GetAxis("Horizontal"));

        // Prints input on vertical axis
        Debug.Log("H: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}