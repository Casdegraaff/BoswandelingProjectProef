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


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNut", 0.4f,0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player_script.score.ToString();
    }

    void SpawnNut()
    {
        float tempPos = Random.Range(-2.5f, 2.5f);
        Instantiate(Nut_prefab, new Vector3(tempPos, 10f, 0), Quaternion.identity);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }
}
