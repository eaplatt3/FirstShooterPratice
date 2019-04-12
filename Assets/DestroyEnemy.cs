using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public int value = 1;
   

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
                if (GameManager.gm != null)
                {
                    // tell the game manager to Collect
                    GameManager.gm.Collect(value);
                }
                Destroy(this.gameObject);
                break;

        }
    }
}


