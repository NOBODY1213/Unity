using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

public float Speed = 10f;
private float movex = 0f;

// Use this for initialization
void Start () {
}

// Update is called once per frame
void FixedUpdate () {
movex = Input.GetAxis ("Horizontal");
GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, 0);
}
}