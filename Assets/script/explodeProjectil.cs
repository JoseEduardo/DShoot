using UnityEngine;
using System.Collections;

public class explodeProjectil : MonoBehaviour {
	public bool destInst = false;
	public float destroyTime = 5;

	void OnCollisionEnter(Collision collision) {
		if (collision.transform.tag != transform.tag) {

			if(destInst){
				Destroy (this.gameObject);
			}else{
				Destroy(this.gameObject, destroyTime);
			}
		}
	}
}
