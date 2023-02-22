using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class NutMenuManager : MonoBehaviour
{
    public GameObject game_manager,start_menu,win_screen,ui;
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
        game_manager.SetActive(true);
        ui.SetActive(true);
    }

    public void WinScreen()
    {
        ui.SetActive(false);
        game_manager.SetActive(false);
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
