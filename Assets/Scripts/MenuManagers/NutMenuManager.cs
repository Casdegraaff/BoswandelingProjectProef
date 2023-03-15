using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class NutMenuManager : MonoBehaviour
{
    public GameObject game_manager,start_menu,win_screen,ui,score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()  // Hier zet hij de game aan en verbergt de startscherm
    {
        start_menu.SetActive(false);
        game_manager.SetActive(true);
        ui.SetActive(true);
        score.SetActive(true);
    }

    public void WinScreen() // Hier zet hij de game uit en laat de winscreen zien
    {
        ui.SetActive(false);
        game_manager.SetActive(false);
        win_screen.SetActive(true);
        score.SetActive(false);
    }

    public void Retry() // Laat de game opnieuw op
    {
        SceneManager.LoadScene("NutDrop");
    }

    public void Exit() // Gaat terug naar de gps map
    {
        SceneManager.LoadScene("SampleScene");
    }
}
