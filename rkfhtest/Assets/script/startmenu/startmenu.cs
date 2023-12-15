using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void gamestart()
    {
        SceneManager.LoadScene("gamescene");
    }

    public void gameend()
    {
        Application.Quit();
    }

    public void gostart()
    {
        SceneManager.LoadScene("startmenu");
    }
}
