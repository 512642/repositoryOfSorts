using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Text scoreCounter;
    int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = playerMovement.playerScore;
        scoreCounter.text = "Score: " + playerScore;
    }

    
}
