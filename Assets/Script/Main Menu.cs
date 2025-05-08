using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;

    public string newLevel1;
    public string newLevel2;
    public string newLevel3;

    void Start()
    {
        Level1.onClick.AddListener(() => LoadScene(newLevel1));
        Level2.onClick.AddListener(() => LoadScene(newLevel2));
        Level3.onClick.AddListener(() => LoadScene(newLevel3));
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
