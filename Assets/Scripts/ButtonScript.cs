using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button newGameButton;
    public Button exitButton;

    void Start()
    {
        newGameButton.onClick.AddListener(NewGameClick);
        exitButton.onClick.AddListener(ExitClick);
    }
    void NewGameClick()
    {
        SceneManager.LoadScene("Level1");
    }
    void ExitClick() { 
        Application.Quit();
    }


    void Update()
    {
        
    }
}
