using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public PlayerScript player_script;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Nut")
        {
            Destroy(collision.gameObject);
        }
    }

    void Start()
    { 
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
