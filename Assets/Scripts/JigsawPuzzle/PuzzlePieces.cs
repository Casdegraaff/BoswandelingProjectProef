using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        // spawn gebied van de puzzelstukjes
        transform.position = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-2f, -4f));
    }


    void Update()
    {
        // checkt of de stukjes op de goede plek liggen
        if (Vector3.Distance(transform.position,RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                transform.position = RightPosition;
                InRightPosition = true;
            }
        }
    }
}
