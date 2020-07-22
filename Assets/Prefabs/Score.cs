using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Text scoreText;
  
    private int scoreValue;
    

    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = "Score: " + scoreValue;
       
    }

   
    public void addpoints(int points)
    {
        scoreValue += points;
        scoreText.text = "Score: " + scoreValue;
    }

    public int GetScore() 
    {
        return scoreValue;
    }

}
