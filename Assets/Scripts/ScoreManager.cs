using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int maxScore = 3;

    private int P1Score = 0;

    private int P2Score = 0;

    public TextMeshProUGUI P1Text;

    public TextMeshProUGUI P2Text;

    public void P1Goal()
    {
        P1Score++;
        P1Text.text = P1Score.ToString();
        ScoreCheck();
    }

    public void P2Goal()
    {
        P2Score++;
        P2Text.text = P2Score.ToString();
        ScoreCheck();
    }

    private void ScoreCheck()
    {
        if (P1Score == maxScore || P2Score == maxScore)
        {
            SceneManager.LoadScene(4);
        }
    }
}
