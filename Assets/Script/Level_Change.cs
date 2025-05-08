using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Change : MonoBehaviour
{
    public Button button;
  
    public string newLevel; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnButtonClick()
    {
        SceneManager.LoadScene(newLevel);
        Debug.Log("Play Button Pressed");
    }
}
