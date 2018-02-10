using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void LoadGameBtn()
    {
        //not implemented
    }

    public void ExitGameBtn()
    {
        Application.Quit(); //still need to implement how to deal with this
    }
}
