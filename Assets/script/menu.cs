using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	private bool cursorLocked = false;

	void Start(){
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		cursorLocked = true;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			if(cursorLocked){
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
				cursorLocked = false;
			}else{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
				cursorLocked = true;
			}
		}
	}
}
