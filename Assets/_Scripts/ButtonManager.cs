using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CoinCounter;
    public GameObject PauseMenu;
    public GameObject Player;
    public PlayerController PlayerController;
    public GameObject WinMenu;
    public UnityEvent OnMainMenuButton;
    public Button OnMainMenuSomething;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (MainMenu.activeInHierarchy == true)
        {
           CoinCounter.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    void OnEnable()
    {
        OnMainMenuSomething.onClick.AddListener(OnBackToMenuButton);
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

        if (WinMenu.activeSelf == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }  
    public void OnRestartButton()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
    public void OnPlayButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        MainMenu.SetActive(false);
        CoinCounter.SetActive(true);
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
    public void OnBeskonechniyButton()
    {
        SceneManager.LoadScene("Endless");
    }
    public void OnBackToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
