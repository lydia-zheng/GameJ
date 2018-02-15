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

    public void ExitGameBtn()
    {
        Application.Quit(); //still need to implement how to deal with this
    }

	public void CreditBtn()
	{
		// show credits on click
	}
}
