using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {

    public KeyCode lookForward;
    public KeyCode lookBackward;
    public KeyCode lookRight;
    public KeyCode lookLeft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

     /*   if (Input.GetKeyDown(lookForward))
            transform.Rotate(0, 0, 0);
        //GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(lookBackward))
            transform.Rotate(0, 180, 0);
            */
        if (Input.GetKeyDown(lookRight))
            transform.Rotate(0, 90, 0);
        // GetComponent<Transform>().eulerAngles = new Vector3(0, 90, 0);

        if (Input.GetKeyDown(lookLeft))
            transform.Rotate(0, -90, 0);
        // GetComponent<Transform>().eulerAngles = new Vector3(0, 270, 0 );
    }
}
