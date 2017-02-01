using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

    public GameObject player;

    void Start () 
    {

	}
    
    void LateUpdate () 
    {
		transform.position = new Vector3(0, player.transform.position.y, -10);
    }
}