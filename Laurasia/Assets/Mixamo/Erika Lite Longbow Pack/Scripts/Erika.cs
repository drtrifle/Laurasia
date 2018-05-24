using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erika : MonoBehaviour {

    Animator animator;
    public GameObject ArrowPrefab;
    public Transform BowTransform;

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
        bool playerLeftClick = Input.GetKey(KeyCode.Mouse0);
        animator.SetBool("Attack", playerLeftClick);
        animator.SetBool("Aim", Input.GetKey(KeyCode.Mouse1));

        //Player must hold down aim and click attack to fire arrow
        if (playerLeftClick && Input.GetKey(KeyCode.Mouse1)) {
            //Animator must be in AimGrounded BlendTree
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("AimGrounded")) {
                ShootArrow();
            }
        }
    }

    void ShootArrow() {
        Instantiate(ArrowPrefab, BowTransform.position, transform.rotation);
    }
}
