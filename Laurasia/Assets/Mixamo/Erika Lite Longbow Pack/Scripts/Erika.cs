using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erika : MonoBehaviour {

    Animator animator;
    public Transform ArrowHandTransform;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        GetPlayerInput();
	}

    void GetPlayerInput() {
        //Update if player is Aiming
        animator.SetBool("Attack", Input.GetKey(KeyCode.Mouse0));
        animator.SetBool("Aim", Input.GetKey(KeyCode.Mouse1));
    }
}
