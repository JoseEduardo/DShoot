using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float speed = 250;
	
	public Rigidbody projectile = null;
	
	public int cartuchos = 20;
	public int municion = 6;
	public string PlayerSide = "Red";

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown( "Fire1" ) ) {
			municion -= 1;
			GameObject clone;
			clone = (GameObject)Instantiate(projectile.gameObject, transform.position, transform.rotation);
			//clone.velocity = transform.TransformDirection(Vector3.forward * 10);
			clone.GetComponent<Rigidbody>().AddForce(transform.forward *speed);
			clone.transform.tag = PlayerSide;
		}
	}
}
