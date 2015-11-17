using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

    public GameObject gib = null;
    public GameObject destroyBullet = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {

        Debug.Log(name + " collides with " + other.gameObject.name);

        // Check if tags are different, needed so the player doesn't blow himself up with his own bullets :)
        if (tag != other.gameObject.tag)
        {
            Debug.Log("hit");
            if (gib != null)
            {
                Instantiate(gib, transform.position, gib.transform.rotation);
            }
            Destroy(gameObject);
        }

	}
}