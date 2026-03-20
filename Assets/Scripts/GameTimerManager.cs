using TMPro;
using UnityEngine;

public class GameTimerManager : MonoBehaviour
{
    public TextMeshProUGUI timerUI;
    public float gameTime;

    public bool IsGameTimerEnd;

    private float gameTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer += UnityEngine.Time.deltaTime;

        timerUI.text = string.Format("{0}:{1}, survive until {2}", GetGameMin(), GetGameSec(), GetTotalGameTime());

        IsGameTimerEnd = gameTimer >= gameTime;
    }

    public int GetGameMin()
    { 
        return ((int)(gameTimer / 60));
    }

    public int GetGameSec() 
    {
        return ((int)(gameTimer - GetGameMin() * 60));
    }
    /*
    public void GetGameTime(out int minutes, out int seconds)
    {
        minutes = (int)(gameTimer / 60);
        seconds = (int)(gameTimer - minutes*60); 
    }*/

    public string GetTotalGameTime()
    {
        return "3:00";
    }
}
