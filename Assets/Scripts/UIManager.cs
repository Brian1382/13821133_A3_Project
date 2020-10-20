using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void loadFirstLevel()
    {
        SceneManager.LoadScene("MainScene");
        DontDestroyOnLoad(this);
    }

    public void CloseGame()
    {
        SceneManager.LoadScene("StartScene");
        DontDestroyOnLoad(this);
    }
}
