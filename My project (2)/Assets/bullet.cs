using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody bullet;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clonnedRocket;
            clonnedRocket = Instantiate(bullet, transform.position, transform.rotation);

            clonnedRocket.velocity = transform.TransformDirection(Vector3.forward * 100f);
        }
    }
}
