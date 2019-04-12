using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    void OnCollisionEnter(Collision coll)
    {
        

        GameObject other = coll.gameObject;
        switch (other.tag)
        {
            case "Hero":
                print("Collision");
                Destroy(other.gameObject);
                break;

            case "Bullet":
        
                Destroy(this.gameObject);
                break;

        }
    }
}
