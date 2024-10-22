using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeOnCollision : MonoBehaviour
{
    public string[] tagsOfTargets;
    private Renderer objectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        foreach (string tag in tagsOfTargets) {
            if (other.gameObject.tag == tag) {
                objectRenderer.material.color = Random.ColorHSV();
                break;
            }
        }
    }
}
