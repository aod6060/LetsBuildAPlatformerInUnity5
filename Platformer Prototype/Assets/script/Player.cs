using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 4.0f;
	// Use this for initialization
	void Start () {
	}

    void FixedUpdate()
    {
        Rigidbody body = this.GetComponent<Rigidbody>();

        float x = Input.GetAxis("Movement") * Time.fixedDeltaTime * speed;

        transform.Translate(x, 0, 0);
    }
}
