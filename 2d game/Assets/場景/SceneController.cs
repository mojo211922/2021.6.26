using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    /// <summary >
    /// 載入遊戲場景
    /// </summary>
    public void LoadGameScene()
    {
        SceneManager.LoadScene("遊戲場景");
    }


    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        print("離開遊戲");
    }
    
}
