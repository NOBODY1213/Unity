using UnityEngine;

//Require Audio Component
[RequireComponent(typeof(AudioSource))]

public class Enter : MonoBehaviour {
	//Audio
	public AudioClip startup;
	AudioSource audio;
	
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.PlayOneShot(startup, 1.0F);
	}
	
}