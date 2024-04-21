using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeButton : MonoBehaviour
{
    public string sceneName; // Name of the scene to load

    void Start()
    {
        // Register the button's click event to call the LoadScene method
        GetComponent<Button>().onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        // Load the scene by name
        SceneManager.LoadScene(sceneName);
    }
}


