using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverManager : MonoBehaviour
{
    public GameTimerManager gameTimerManager;
    public PlayerMovement playerMovement;

    private void Update()
    {
        if(gameTimerManager.IsGameTimerEnd)
            GameWin();
        else if(playerMovement.IsDead)
            GameLose();
    }

    private void GameWin()
    {
        SceneManager.LoadScene("GameWon");
    }

    private void GameLose()
    {
        SceneManager.LoadScene("GameLose");
    }
}
