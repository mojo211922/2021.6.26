using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    /// <summary >
    /// ���J�C������
    /// </summary>
    public void LoadGameScene()
    {
        SceneManager.LoadScene("�C������");
    }


    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        print("���}�C��");
    }
    
}
