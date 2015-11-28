using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed = 3.0f;
    public float sinAmplitude = 0.01f;
    public float sinFrequency = 0.01f;
    private float horizontalOffset = 0.0f;

    private float time;

    public int health = 2; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MoveForward(speed);
	}

    void MoveForward(float _speed)
    {
        time += Time.deltaTime;
        //Moves enemy forward
        transform.position -= transform.up * _speed * Time.deltaTime;

        //Adjust horizontal pos by sine wave
        horizontalOffset = Mathf.Sin(time * sinFrequency) * sinAmplitude;

        transform.position += horizontalOffset * transform.right;
    }
}

