using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour {

    private Camera mainCam;
    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                agent.SetDestination(hit.point);
            }
        }
	}
}
