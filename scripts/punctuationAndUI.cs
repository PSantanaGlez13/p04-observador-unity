using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class punctuationAndUI : MonoBehaviour
{
    public recolect[] recolects;
    public delegate void ReachedOneHundredPoints();
    public event ReachedOneHundredPoints reward;
    private TMP_Text text;
    private int punctuation;
    // Start is called before the first frame update
    void Start()
    {
        punctuation = 0;
        text = this.GetComponent<TMP_Text>();
        text.text = "Punctuation: " + punctuation;
        foreach (recolect r in recolects) {
            r.notifier += IncreasePunctuation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncreasePunctuation(int points) {
        punctuation += points;
        text.text = "Punctuation: " + punctuation;
        if (punctuation % 100 == 0) {
            reward();
        }
    } 
}
