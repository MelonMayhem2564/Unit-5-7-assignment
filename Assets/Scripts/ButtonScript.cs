using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ButtonQuit()
    {
        SceneManager.LoadScene("Main menu");
        AudioManager.instance.PlayClip(1);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Dummy game");
        AudioManager.instance.PlayClip(0);
    }
    public void Selection()
    {
        AudioManager.instance.PlayClip(0);
    }
    public void Exit()
    {
        AudioManager.instance.PlayClip(1);
    }
    public void ButtonMethodQuitGame()
    {
        AudioManager.instance.PlayClip(1);
        Application.Quit();
    }
}
