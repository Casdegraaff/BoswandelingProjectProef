using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("NutDrop");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Memory");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Jigsaw");
    }
    public void Loadscene4()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
