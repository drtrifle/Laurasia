using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour {

    private Camera mainCam;
    private NavMeshAgent agent;

    public ThirdPersonCharacter character;

	// Use this for initialization
	void Start () {
        mainCam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        character = GetComponent<ThirdPersonCharacter>();
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

        if (agent.remainingDistance > agent.stoppingDistance) {
            character.Move(agent.desiredVelocity, false, false);
        } else {
            character.Move(Vector3.zero, false, false);
        }
    }
}
