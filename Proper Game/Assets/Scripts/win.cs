using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(3);
    }

    public void again()
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
