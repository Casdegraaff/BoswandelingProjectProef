using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int speed;

    public int score = 0;
    public GameManager game_manager;
    public NutMenuManager menu_manager;
    private void OnTriggerEnter2D(Collider2D collison)
    {
        //als een noot de mand raakt hier, dan gaat de score omhoog met het getal wat je hier neerzet
        if (collison.tag == "Nut")
        {
            score += 1;
            Destroy(collison.gameObject);   //Nut
        }
        //als de target score is bereikt dan stopt hij de game hier, en geeft je de winscreen
        if (score == game_manager.targetScore)
        {
            game_manager.StopSpawning();
            Debug.Log("you won!");
            menu_manager.WinScreen();

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    //tijdelijk oplossing waar de mand kan bewegen met de pijltjestoetsen op een keybord
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        // hier zet hij de grens van waar de speler kan komen.
        currentXPos = Mathf.Clamp(currentXPos, -1.5f, 1.5f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }

    
}


