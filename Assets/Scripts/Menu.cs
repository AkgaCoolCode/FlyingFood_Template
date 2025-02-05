using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void StartScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
























}
