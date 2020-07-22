using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverUI;

    public void GameOver() 
    {
        gameoverUI.SetActive(true);
    
    }
}
