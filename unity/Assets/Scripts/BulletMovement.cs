using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    public float speed = 10.0f;
    public int damage = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * speed * Time.deltaTime;
	}
}
