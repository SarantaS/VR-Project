using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void RestartSim()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitSim()
    {
        Application.Quit();
    }
    public void Travel()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "House")
        {
            SceneManager.LoadScene("School");
        }
        else
        {
            SceneManager.LoadScene("House");
        }
    }
}

