using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float playerSpeed = 3f;
    public float playerSlowSpeed = 1f;
    float playerCurrentSpeed;
    public bool spreadShotActive = false;

    public GameObject gunMain;
    public GameObject gunLeft;
    public GameObject gunRight;


    // Use this for initialization
    void Start () {
        playerCurrentSpeed = playerSpeed;
        SetSpreadShot(false);
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

        // Check if the player has the spread shot powerup
        CheckSpreadShot();

       transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f) * playerCurrentSpeed * Time.deltaTime;

    }

    void CheckSpreadShot()
    {
        if (spreadShotActive)
        {
            gunLeft.SetActive(true);
            gunRight.SetActive(true);
        }
        else if (!spreadShotActive)
        {
            gunLeft.SetActive(false);
            gunRight.SetActive(false);
        }
    }

    void SetSpreadShot(bool _val)
    {
        spreadShotActive = _val;
    }
}
