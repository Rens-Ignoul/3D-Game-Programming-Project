using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelButton4 : MonoBehaviour
{
    public Button nextLevelButton;

    private void Start()
    {
        nextLevelButton.onClick.AddListener(LoadNextLevel);
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(5);
    }
}
