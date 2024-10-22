using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class speedBoostText : MonoBehaviour
{
      public punctuationAndUI notifier;
    private TMP_Text text;
    private int boost;
    // Start is called before the first frame update
    void Start()
    {
        boost = 0;
        notifier.reward += IncreaseReward;
        text = this.GetComponent<TMP_Text>();
        text.text = "Speed boost activated " + boost + " times";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncreaseReward() {
      text.text = "Speed boost activated " + ++boost + " times";
    } 
}
