using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleMenuManager : MonoBehaviour
{
    public GameObject start_menu,win_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        start_menu.SetActive(false);
       
    }

    public void WinScreen()
    {
       
        win_screen.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("NutDrop");
    }

    public void Exit()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
