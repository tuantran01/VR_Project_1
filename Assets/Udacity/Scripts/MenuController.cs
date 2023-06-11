using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void Green()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Maze");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
