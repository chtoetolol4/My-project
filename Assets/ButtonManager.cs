using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CoinCounter;
    public GameObject PauseMenu;
    public GameObject Player;
    public PlayerController PlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoinCounter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            CoinCounter.SetActive(false);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PlayerController.speed = 0;
        }
    }  
    public void OnRestartButton()
    {
        string currentSceneName = SceneManager.GetActiveScene().name; 
        SceneManager.LoadScene(currentSceneName);
    }
    public void OnPlayButton()
    {
        MainMenu.SetActive(false);
        CoinCounter.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    public void OnContinueButton()
    {
        PauseMenu.SetActive(false);
        CoinCounter.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerController.speed = 7;
    }
}
