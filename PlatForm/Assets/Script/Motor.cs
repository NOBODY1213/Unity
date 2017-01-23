using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

public float Speed = 10f;
public float SpeedY = 1f;
private float movex = 0f;
private float movey = 0f;

// Use this for initialization
void Start () {
}

// Update is called once per frame
void FixedUpdate () {
movex = Input.GetAxis ("Horizontal");
movey = Input.GetAxis ("Vertical");
GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * SpeedY);
}
}