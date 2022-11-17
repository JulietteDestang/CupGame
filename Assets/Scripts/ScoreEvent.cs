using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreEvent : MonoBehaviour
{
    private int scoreTotal = 0;

    public GameObject floatingScore;
    // Start is called before the first frame update
    void Start()
    {
        floatingScore.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "score " + scoreTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScore()
    {
        scoreTotal += 1;
    }

    public void DisplayScore()
    {
        floatingScore.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "score " + scoreTotal;
    }
}
