using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

    public GameObject gib = null;
    public GameObject destroyBullet = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D () {

        Debug.Log("hit");
        if (gib != null)
        {
            Instantiate(gib, transform.position, gib.transform.rotation);
        }
        Destroy(gameObject);
	}
}