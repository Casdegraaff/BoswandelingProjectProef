using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleDragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    void Start()
    {
        
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            // raycast die detecteerd op welke positie je klikt
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                // kijkt of je puzzel stukje op de goede plek ligt in de puzzel
                if (!hit.transform.GetComponent<PuzzlePieces>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PuzzlePieces>().Selected = true;
                }
            }
        }

       //zorgt ervoor dat je een puzzel stukje op kan pakken en neer kan zetten
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PuzzlePieces>().Selected = false;
                SelectedPiece = null;
            }
        }

        if(SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
