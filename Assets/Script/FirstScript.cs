using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("My firstScript Awake function");
    }
    void Start()
    {
        Debug.Log("My firstScript start function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Update input F Pressed");
        }
        if (Input.GetKey(KeyCode.F) || Input.GetMouseButton(0))
        {
            Debug.Log("Update input F");
        }    
        if (Input.GetKeyUp(KeyCode.F)|| Input.GetMouseButtonUp(0))
        {
            Debug.Log("Update Input F Released");
        }
    }
}
