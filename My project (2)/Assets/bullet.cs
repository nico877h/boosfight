using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float cooldownTime = 1f;
    private float lastUsedTime;

    public Rigidbody bullet;
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > lastUsedTime + cooldownTime)
        {
            Rigidbody clonnedRocket;
            clonnedRocket = Instantiate(bullet, transform.position, transform.rotation);

            clonnedRocket.velocity = transform.TransformDirection(Vector3.forward * 100f);

            lastUsedTime = Time.time;
        }
    }
}
