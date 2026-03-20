using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResultUI : MonoBehaviour
{
    public bool win;
    public Button gameoverButton;

    private void Start()
    {
        gameoverButton.onClick.AddListener(OnGameOverClick);
    }

    private void OnGameOverClick()
    {
        SceneManager.LoadScene("Level");
    }
}
