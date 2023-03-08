using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour {
  //De Instellingen voor het aantal kaarten\\
  public const int gridRows = 4;
  public const int gridCols = 3;

  //De positie van de kaarten\\
  public const float offsetX = 1.5f;
  public const float offsetY = 2.5f;

  //De code voor de orginele kaart\\
  [SerializeField] private memoryCard originalCard;

  //De Array waar alle images ingaan van de kaarten\\
  [SerializeField] private Sprite[] images;

    //De check welke kaarten er zijn om geflipt\\
    private memoryCard _firstRevealed;
    private memoryCard _secondRevealed;

    //Score bijhouden\\
    private int _score = 0;    

    void Start() {
        //De vector om de orginele kaart zijn positie op te halen\\
        Vector3 startPos = originalCard.transform.position;
        
        //De groote van de array en welke erbij elkaar horen\\
        int[] numbers = {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5};   
            //Functie om de kaarten random te laten gaan\\
            numbers = ShuffleArray(numbers);

            //De funtie om de kaarten te spawen \\  
            for (int i = 0; i < gridCols; i++) {
                for (int j = 0; j < gridRows; j++) {
                    memoryCard card;
                    if (i == 0 && j == 0) {
                    card = originalCard;
                    } else {
                    card = Instantiate(originalCard) as memoryCard;
                    }

                    int index = j * gridCols + i;
                    int id = numbers[index];    
                    card.SetCard(id, images[id]);

                    //Maakt dat de kaarten niet tegen elkaar aan komen\\
                    float posX = (offsetX * i) + startPos.x;
                    float posY = -(offsetY * j) + startPos.y;

                    //Maakt dat de kaarten een nieuwe positie krijgt\\
                    card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }

    //De functie waardoor de kaarten random worden gemaakt\\
    private int[] ShuffleArray(int[] numbers) {    
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++ ) {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    //Check welke kaarten reaveald zijn en of ze gelijk zijn\\
    public void CardRevealed(memoryCard card) {
        if (_firstRevealed == null) {
            _firstRevealed = card;
        } else {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());    
        }
    }

    //Kijk of hij nog een kaart mag reavelen\\
    public bool canReveal {
        get {return _secondRevealed == null;}    
    }

    //Controleert of de kaarten gelijk zijn en scoort punten\\
    private IEnumerator CheckMatch() {
        if (_firstRevealed.id == _secondRevealed.id) {
            _score++;    
        Debug.Log("Score: " + _score);
        }
        else {
            yield return new WaitForSeconds(.5f);
            _firstRevealed.Unreveal();    
        _secondRevealed.Unreveal();
        }
        _firstRevealed = null;    
        _secondRevealed = null;
    }
}