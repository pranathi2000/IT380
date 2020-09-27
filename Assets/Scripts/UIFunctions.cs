using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIFunctions : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("Hello World! This is my first script");
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
                
    
}
