using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
