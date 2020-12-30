using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
    public AudioSource bgm,konodio;
    void bgmplay()
    {
        bgm.Play();
    }
    void Start()
    {
        InvokeRepeating("bgmplay",0,60);
    }
    public void PlayGame()
    {
        konodio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
