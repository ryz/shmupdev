using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public float shotDelay = 0.2f;
    private bool readytoShoot = true;

    public GameObject bullet;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Shooting
        if (Input.GetButton("Fire1") && readytoShoot)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            readytoShoot = false;
            Invoke("ResetReadyToShoot", shotDelay);
        }

    }

    void ResetReadyToShoot()
    {
        readytoShoot = true;
    }
}
