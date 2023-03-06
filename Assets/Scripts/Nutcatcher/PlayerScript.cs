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
        if (collison.tag == "Nut")
        {
            score += 1;
            Destroy(collison.gameObject);   //Nut
        }

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
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        // Line 29 controls the border of where the player is allowed to go.
        currentXPos = Mathf.Clamp(currentXPos, -2.5f, 2.5f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }
}
