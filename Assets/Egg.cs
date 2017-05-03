using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {
    Rigidbody rd;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    } 
	void OnCollisionEnter(Collision col)
    {
        // Detect if egg is colliding with Basket
            rd.isKinematic = true;
            transform.SetParent(col.transform);
    }
}
