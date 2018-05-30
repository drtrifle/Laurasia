using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : MonoBehaviour {

    Animator animator;

    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        GetPlayerInput();
    }

    void GetPlayerInput() {
        //Update if player is Aiming
        bool playerLeftClick = Input.GetKey(KeyCode.Mouse0);
        animator.SetBool("LeftClick", playerLeftClick);
        animator.SetBool("RightClick", Input.GetKey(KeyCode.Mouse1));

        //Player must hold down aim and click attack to fire arrow
        if (playerLeftClick && Input.GetKey(KeyCode.Mouse1)) {

        }
    }
}
