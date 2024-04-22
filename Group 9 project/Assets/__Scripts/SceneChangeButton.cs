using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeButton : MonoBehaviour
{
    public string sceneName; // Name of the scene to load

    void Start()
    {
        Button buttonVar = GetComponent<Button>();
        if(buttonVar != null){
            // Register the button's click event to call the LoadScene method
            buttonVar.onClick.AddListener(LoadScene);
        }
    }

    void LoadScene()
    {
        // Load the scene by name
        SceneManager.LoadScene(sceneName);
    }
}


