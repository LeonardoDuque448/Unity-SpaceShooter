using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverUI : MonoBehaviour
{
    public Score score;
    public Text ScoreLabel;
    public Text hiscoreLabel;
    private void OnEnable()
    {
        int currentscore = score.GetScore();
        ScoreLabel.text = "Score: " + currentscore;

        int highscore = PlayerPrefs.GetInt("highscore", 0);
        hiscoreLabel.text = "Highscore: " + highscore;
        if (currentscore > highscore)
            PlayerPrefs.SetInt("highscore", currentscore);
    }
    public void RestartGame()
    {
        int CurrentIindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentIindex);
    }

    // Update is called once per frame
    public void CloseGame()
    {
        Application.Quit();
    }
}
