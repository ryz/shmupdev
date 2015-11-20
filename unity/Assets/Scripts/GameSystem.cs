using UnityEngine;
using System.Collections;

public class GameSystem : MonoBehaviour {

    public bool isGameOver = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(isGameOver)
        {
            // TODO: GUI stuff 

            if (Input.GetButton("Fire1")) {
                Application.LoadLevel(0);
            }
        }

	}
}
