using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        //SceneManager.LoadScene("Quit");
    }

    public int SceneIndex;

    public int LevelSceneIndex;
        
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }


    public void NextLevelLoader()
    {
        SceneManager.LoadScene(LevelSceneIndex);
    }

}
