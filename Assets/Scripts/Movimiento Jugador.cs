using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public float rotation;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>(); //sirve para añadir el componente al script
    }

    
    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            transform.localEulerAngles = transform.localEulerAngles
                + new Vector3(0, 0, 1) * rotation * Time.deltaTime;

        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.localEulerAngles = transform.localEulerAngles
                + new Vector3(0, 0, -1) * rotation * Time.deltaTime;

        }
            

        if (Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(force * Time.deltaTime * transform.up);

        }
    }
}
