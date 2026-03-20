using UnityEngine;

public class GameTimerManager : MonoBehaviour
{
    public float gameTime;

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
    }

    public bool IsGameTimerEnd => gameTimer >= gameTime;

    public void GetGameTime(out int minutes, out int seconds)
    {
        minutes = (int)(gameTimer / 60);
        seconds = (int)(gameTimer - minutes*60); 
    }

    public void GetTotalGameTime(out int minutes, out int seconds)
    {
        minutes = (int)(gameTime / 60);
        seconds = (int)(gameTime - minutes*60); 
    }
}
