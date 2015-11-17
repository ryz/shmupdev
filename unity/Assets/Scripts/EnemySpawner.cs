using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        Instantiate(enemy, transform.position, enemy.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > Time.time + 5)
        {
            Instantiate(enemy, transform.position, enemy.transform.rotation);
        }
	}
}
