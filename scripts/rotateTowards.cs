using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTowards : MonoBehaviour
{
    public GameObject target;
    public collisionEventTag notifier;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnCollision += Rotate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Rotate(string tag) {
        if (tag == this.tag) {
            Vector3 pos = target.transform.position;
            //pos.z = -pos.z;
            this.transform.LookAt(pos);
        }
    }
}
