using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSc : MonoBehaviour
{
    public GameObject Bee;
    public Text PlayerScoreUI;
    public int PlayerScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScoreUI.text = PlayerScore.ToString();
    }
    
}
