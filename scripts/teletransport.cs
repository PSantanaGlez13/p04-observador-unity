using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransport : MonoBehaviour
{
    public GameObject target;
    public collisionEventTag notifier;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnCollision += Teletransport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Teletransport(string tag) {
        if (tag == this.tag) {
            //this.GetComponent<Rigidbody>().Move(target.transform.position, this.transform.rotation);
            Vector3 pos = target.transform.position;
            pos.y = this.transform.position.y;
            pos.z -= 1; // Some space between egg and spider
            this.transform.Translate(pos - this.transform.position);
        }
    }

}
