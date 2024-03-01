using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public int pScore;
    public Text scoretext;
    public GameObject gameoverscreen;
    public GameObject crashScreen;
    public GameObject boundsScreen;
    [ContextMenu("Increase Scire")]
    public void addScore(int pAmount)
    {
        pScore += pAmount;
        scoretext.text = pScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(bool crash)
    {
        gameoverscreen.SetActive(true);
        if (crash == true && boundsScreen.activeSelf == false)
        {
            crashScreen.SetActive(true);
        }
        else if (crash == false && crashScreen.activeSelf == false)
        {
            boundsScreen.SetActive(true);  
        }
    }
}