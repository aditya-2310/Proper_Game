using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ded : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
