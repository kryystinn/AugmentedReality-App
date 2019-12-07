using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void BryceScene()
    {
        SceneManager.LoadScene("BryceScene");
    }

    public void JodyScene()
    {
        SceneManager.LoadScene("JodyScene");
    }

    public void JasperScene()
    {
        SceneManager.LoadScene("JasperScene");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
