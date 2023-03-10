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

    public void StartButton() // Hier zet hij de game aan en verbergt de startscherm
    {
        start_menu.SetActive(false);
       
    }

    public void WinScreen() // Hier zet hij de game uit en laat de winscreen zien
    {
       
        win_screen.SetActive(true);
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
