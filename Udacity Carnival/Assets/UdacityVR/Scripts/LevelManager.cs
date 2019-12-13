using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public Transform Menu;

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu(bool clicked)
    {
        if (clicked == true)
        {
            Menu.gameObject.SetActive(false);
        }
        else
        {
            Menu.gameObject.SetActive(true);
        }
    }


}
