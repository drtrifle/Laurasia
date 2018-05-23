using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public float ArrowLifetime;
    public float ArrowInitialForce;

    Rigidbody arrowRigidbody;


	// Use this for initialization
	void Start () {
        StartCoroutine(DestroyAfterLifetime());
        arrowRigidbody = GetComponent<Rigidbody>();
        arrowRigidbody.AddForce(transform.forward * ArrowInitialForce);
    }

    IEnumerator DestroyAfterLifetime() {
        yield return new WaitForSecondsRealtime(ArrowLifetime);
        Destroy(gameObject);
    }
}
