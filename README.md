# p04-observador-unity
- Pablo Santana González alu0101480541@ull.edu.es
------------------------------------
# Ejercicio 1.
Este es el script para el desplazamiento del cubo:
```
public class movement : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {
        float vertical_movement = Input.GetAxis("Vertical") * speed;
        float horizontal_movement = Input.GetAxis("Horizontal") * speed;
        Vector3 movement = new Vector3(horizontal_movement * Time.deltaTime, 0f, vertical_movement * Time.deltaTime);
        gameObject.transform.Translate(movement);
    }
}
```
