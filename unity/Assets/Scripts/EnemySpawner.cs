using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public float spawnInitialDelay = 1.0f;
    public float spawnRepeatRate = 2.0f;

    public float movementSpeed = 1f;

    public float movementLimitLeft = -0.8f;
    public float movementLimitRight = 1f;

    private int movementDirection = 1;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", spawnInitialDelay, spawnRepeatRate);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > movementLimitRight)
        {
            movementDirection = -1;
        }
        else if (transform.position.x < movementLimitLeft)
        {
            movementDirection = 1;
        }

        transform.position += transform.right * movementDirection * movementSpeed * Time.deltaTime;
	}

    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, enemy.transform.rotation);
    }

}