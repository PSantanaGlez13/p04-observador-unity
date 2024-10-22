using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recolect : MonoBehaviour
{
    public int pointValue;
    public delegate void RecolectPoint(int point);
    public event RecolectPoint notifier;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) {
        this.GetComponent<Renderer>().enabled = false;
        notifier(pointValue);
    }
}
