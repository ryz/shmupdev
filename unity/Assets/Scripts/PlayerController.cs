using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float playerSpeed = 3f;
    public float playerSlowSpeed = 1f;
    float playerCurrentSpeed;

    public float shotDelay = 0.2f;
    private bool readytoShoot = true;

    public GameObject bullet;

    // Use this for initialization
    void Start () {
        playerCurrentSpeed = playerSpeed;
	}
	
	// Update is called once per frame
	void Update () {


        // Speed
        if (Input.GetKeyDown("left ctrl") || Input.GetButtonDown("Fire2"))
        {
            playerCurrentSpeed = playerSlowSpeed;
        }
        else if (Input.GetKeyUp("left ctrl") || Input.GetButtonUp("Fire2"))
        {
            playerCurrentSpeed = playerSpeed;
        }


        // Shooting
        if(Input.GetButton("Fire1") && readytoShoot)
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            readytoShoot = false;
            Invoke("ResetReadyToShoot", shotDelay);
        }
    

       transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f) * playerCurrentSpeed * Time.deltaTime;

    }

    void ResetReadyToShoot()
    {
        readytoShoot = true;
    }
}
