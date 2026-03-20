using UnityEngine;

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
        
    }

    private void GameLose()
    {
        
    }
}
