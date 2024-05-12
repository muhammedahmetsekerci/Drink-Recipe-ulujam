using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void levelAgainButton()
    {
        SceneManager.LoadScene(1);
    }
}
