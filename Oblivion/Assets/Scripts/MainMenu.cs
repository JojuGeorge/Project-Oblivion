using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string startLevel;

    public void NewGame()
    {
        Application.LoadLevel(startLevel);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
