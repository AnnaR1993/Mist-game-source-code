using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonBehaviour : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game quitted!");
    }
}
