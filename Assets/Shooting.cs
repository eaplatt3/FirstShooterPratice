using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Rigidbody projectile;
    public int speed = 50;
    public float angle = 10.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("3"))
        {
            angle -= 0.1f;
        }
        Vector3 v = new Vector3(Input.GetAxisRaw("Horizontal"), -1f,
                            Input.GetAxisRaw("Vertical"));


        GetComponent<Rigidbody>().AddForce(v * 20);

        transform.Rotate(new Vector3(0, Input.GetAxisRaw("vc") * 10, 0));


        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position + transform.forward, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * speed + Vector3.up * angle);
            Object.Destroy(clone, 2.0f);
        }
    }
}
