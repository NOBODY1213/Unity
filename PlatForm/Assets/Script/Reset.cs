using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	public GameObject Respawn;

	// Use this for initialization
	void Start () {
	}
	
	void OnCollisionEnter2D(Collision2D coll){
	     if(coll.gameObject.tag=="Crash")
	     {
			transform.position = new Vector3(Respawn.transform.position.x, Respawn.transform.position.y, Respawn.transform.position.z);
			transform.rotation = Quaternion.identity;
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
		 }
	}

}