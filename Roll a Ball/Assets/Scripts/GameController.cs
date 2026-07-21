using UnityEngine;
using TMPro;
using System;
public class GameController : MonoBehaviour
{
    private int score = 0;
    public TMP_Text ScoreText;

    public GameObject WinLoseContainer;
    public TMP_Text WinLoseText;
    public int Goal = 20;

    public TMP_Text TimerText;
    public float Timer;
    private bool isGameActive = true;

    public GameObject Player;

    public void AddScore(int value)
    {
        if (isGameActive)
        {

            score += value;
            SetScoreText();
            if (score >= Goal)
            {
                WinLoseContainer.SetActive(true);
                WinLoseText.text = "You Win!";
                WinLoseText.color = Color.green;
                isGameActive = false;
                Player.GetComponent<Ballmovement>().enabled = false;
            }
        }


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetScoreText();

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive == true)
        {
            if(Timer >= 0f)
            {
                Timer -= Time.deltaTime;
            }
            else
            {
                WinLoseContainer.SetActive(true);
                WinLoseText.text = "You Lose!";
                WinLoseText.color = Color.red;
                isGameActive=false;

            }
            TimeSpan timeData = TimeSpan.FromSeconds(Timer);
            TimerText.text = timeData.ToString(@"mm\:ss\.ff");
        }
    }

    private void SetScoreText()
    {
        ScoreText.text = $"Score: {score}/{Goal}";

    }

}
