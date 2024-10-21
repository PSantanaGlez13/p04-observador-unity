# p04-observador-unity
- Pablo Santana González alu0101480541@ull.edu.es
------------------------------------
# Ejercicio 1.

El cilindro manda un mensaje a todos sus subscriptores (las esferas) haciendo que estas se muevan hacia el objeto que les corresponda. Como podemos ver en el GIF, las esferas de tipo 2 se mueven al cilindro

![Ejercicio 1](media/Ejercicio1.gif)

Los scripts se han hecho genéricos para poder ser reusados entre todos los objetos de la escena (o futuros objetos en otras escenas). Desde el inspector de escenas podemos asignar el notificador a las esferas, así como el objeto al que queramos que se dirijan tras la colisión.

Este es el script para el desplazamiento del cubo:
```c#
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
Para que el cilindro actue como notificador de colisiones del mismo:
```c#
public class collisionEvent : MonoBehaviour
{
    public delegate void CollisionEventNotifier();
    public event CollisionEventNotifier OnCollision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube") {
            OnCollision();
        }
    }
}
```
Para el movimiento de las esferas:
```c#
public class moveTowards : MonoBehaviour
{
    public GameObject target;
    public collisionEvent notifier;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnCollision += MoveTowards;
    }
    // Update is called once per frame
    void Update()
    {  
    }
    void MoveTowards() {
        this.transform.Translate((target.transform.position - this.transform.position).normalized, Space.World);
    }
}
```

# Ejercicio 2.
