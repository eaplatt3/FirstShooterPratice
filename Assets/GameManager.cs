using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager gm;

    [Tooltip("If not set, the player will default to the gameObject tagged as Player.")]
    public GameObject player;

    public enum gameStates { Playing };
    public gameStates gameState = gameStates.Playing;

    public int score = 0;
  

    public GameObject mainCanvas;
    public Text mainScoreDisplay;
  

    

   

    void Start()
    {
        if (gm == null)
            gm = gameObject.GetComponent<GameManager>();

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        

        // setup score display
        Collect(0);

    }

    void Update()
    {
        
                  

             
                           
        

    }


    public void Collect(int amount)
    {
        score += amount;
      
        
        mainScoreDisplay.text = "Kills " + score.ToString();
        

    }
}
