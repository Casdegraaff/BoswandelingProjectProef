using UnityEngine;
using System.Collections;

public class memoryCard : MonoBehaviour {
//Cardback dit is de foto voor de achterkant van de kaart\\
[SerializeField] private GameObject cardBack;

//Is om de kaarten mangager te laden\\
[SerializeField] private CardManager controller;

private int _id;

public int id {
    get {return _id;}    
}

//Functie om te flippen en de voorkant van de kaart te laten zien\\
public void OnMouseDown() {
        if (cardBack.activeSelf && controller.canReveal) {    
            cardBack.SetActive(false);
            controller.CardRevealed(this);    
        }
    }

    //Funcite om hem als de kaarten niet matchen om te draaien\\
    public void Unreveal() {    
        cardBack.SetActive(true);
    }

    //Funcite om de kaart in te laden met ze id eraan vast\\
    public void SetCard(int id, Sprite image) {    
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;    
    }
}