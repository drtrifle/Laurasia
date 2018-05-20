using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    private Vector3 startPosition;
    private Quaternion startRotation;


    // Use this for initialization
    void Start () {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResetRotationAndPositionToStart() {
        transform.rotation = startRotation;
        transform.position = startPosition;
    }

    private void OnTriggerEnter(Collider colli) {
        if (colli.CompareTag("Death")) {
            ResetRotationAndPositionToStart();
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        }
    }
}
