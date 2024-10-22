using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    public GameObject target;
    public collisionEvent notifier;
    public collisionEventTag notifierTag;
    // Start is called before the first frame update
    void Start()
    {
        //notifier.OnCollision += MoveTowards;
        notifierTag.OnCollision += MoveTowardsWithTag;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveTowards() {
        // No rigidbody or kinematic rigidbodys
        this.transform.Translate((target.transform.position - this.transform.position).normalized, Space.World);

        // For non kinematic rigidbodys
        //this.GetComponent<Rigidbody>().Move((target.transform.position - this.transform.position).normalized, this.transform.rotation);
    }
    void MoveTowardsWithTag(string someTag) {
        if (this.tag == someTag) MoveTowards();
    }
}
