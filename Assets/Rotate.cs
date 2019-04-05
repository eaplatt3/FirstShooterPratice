using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float spd = 1.0f;
    public float mspd = .1f;
    private bool flge = false;

    public Camera camera1;
    public Camera camera2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              
        
        transform.Rotate(new Vector3(0, Input.GetAxisRaw("vc")*spd, 0));
        transform.Translate(new Vector3(Input.GetAxisRaw("cc"), 0, 0) * mspd);
       

        if (Input.GetKeyDown("1")) { flge = !flge; }
        
            camera1.enabled = !flge;
            camera2.enabled = flge;
       

        

    }
}
