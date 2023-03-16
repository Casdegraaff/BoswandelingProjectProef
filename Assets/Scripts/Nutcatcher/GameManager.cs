using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Nut_prefab;
    public int targetScore = 10;
    public PlayerScript player_script;
    public TMP_Text text;


    // Hier kan je de spawnrate van de noten aanpassen
    void Start()
    {
        InvokeRepeating("SpawnNut", 0.4f,0.4f);
    }

    // Dit geeft de score weer van de game
    void Update()
    {
        text.text = player_script.score.ToString();
    }

    void SpawnNut()
    {
        //hier spawnt hij de noten tussen 2 posities, en pakt hij de noot prefab die wij willen spawnen
        float tempPos = Random.Range(-2.5f, 2.5f);
        Instantiate(Nut_prefab, new Vector3(tempPos, 10f, 0), Quaternion.identity);
    }
    //dit stopt het spawning
    public void StopSpawning()
    {
        CancelInvoke();
    }
}
