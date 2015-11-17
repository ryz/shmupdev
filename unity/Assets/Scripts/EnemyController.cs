using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed = 3.0f;
    public int health = 2; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.up * speed * Time.deltaTime;
	}
}
