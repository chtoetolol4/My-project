using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnStoryButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnEndlessModeButton()
    {
        SceneManager.LoadScene("Endless");
    }
}
