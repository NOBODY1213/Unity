using UnityEngine;
using System.Collections;

//Require Audio Component
[RequireComponent(typeof(AudioSource))]

public class Reset : MonoBehaviour {

	//Audio
	public AudioClip impact;
	AudioSource audio;

	public GameObject Respawn;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter2D(Collision2D coll){
	     if(coll.gameObject.tag=="Crash")
	     {
			transform.position = new Vector3(Respawn.transform.position.x, Respawn.transform.position.y, Respawn.transform.position.z);
			transform.rotation = Quaternion.identity;
			audio.PlayOneShot(impact, 1.0F);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);

		 }
	}

}