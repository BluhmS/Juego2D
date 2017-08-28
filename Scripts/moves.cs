using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : StateMachineBehaviour {

	// Use this for initialization
	private void Awake () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Animation.SetBool("WalkD", true);
        }
	}
	
}
