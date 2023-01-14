using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgainButton4 : MonoBehaviour
{
    public Button playAgainButton;

    private void Start()
    {
        playAgainButton.onClick.AddListener(PlayAgain);
        
    }

    private void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;
    }
}
