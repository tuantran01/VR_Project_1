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
        DontDestroyOnLoad(GameObject.Find("Directional Light"));
    }

    public void Next()
    {
        SceneManager.LoadScene("Maze 1");
    }

    public void Back()
    {
        SceneManager.LoadScene("Start");
        if (GameObject.Find("Directional Light") != null)
        {
            Destroy(GameObject.Find("Directional Light"));
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
