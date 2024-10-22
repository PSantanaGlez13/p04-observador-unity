using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punctuationController : MonoBehaviour
{
    public int punctuation;
    public recolect[] recolects;
    // Start is called before the first frame update
    void Start()
    {
        punctuation = 0;
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
        Debug.Log("Punctuation: " + punctuation);
    } 

}
