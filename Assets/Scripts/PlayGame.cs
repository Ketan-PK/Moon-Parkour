using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;

    }
}
