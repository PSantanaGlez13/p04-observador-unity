using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1f;
    public punctuationAndUI notifier;
    // Start is called before the first frame update
    void Start()
    {
        notifier.reward += SpeedUp;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_movement = Input.GetAxis("Vertical") * speed;
        float horizontal_movement = Input.GetAxis("Horizontal") * speed;
        Vector3 movement = new Vector3(horizontal_movement * Time.deltaTime, 0f, vertical_movement * Time.deltaTime);
        gameObject.transform.Translate(movement);
    }

    void SpeedUp() {
        speed *= 2f;
    }
}
