using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuPanel;
    [SerializeField] public GameObject PlayerPlayPanel;

    private void Start()
    {
        Time.timeScale = 1f;
    }


    public void PauseMenu()
    {
	    Time.timeScale = 1f;
        PauseMenuPanel.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        //SceneManager.LoadScene("Level1_Ph1");
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }


    public void Resume()
    {       PlayerPlayPanel.SetActive(false);
            Time.timeScale = 1f;
    }
}
