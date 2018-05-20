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
        }
    }
}
