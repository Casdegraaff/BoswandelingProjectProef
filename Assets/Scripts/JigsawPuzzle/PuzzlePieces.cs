using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzlePieces : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        RightPosition = transform.position;
        // spawn gebied van de puzzelstukjes
        transform.position = new Vector3(Random.Range(-1.25f, 1.25f), Random.Range(-1.5f, -4f));
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
