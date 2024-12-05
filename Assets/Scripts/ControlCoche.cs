using UnityEngine;

public class ControlCoche : MonoBehaviour
{
    public bool estaQuieto;

    public float velocidad = 15f;
    public float velocidadGirar = 75f;
    public float horizontalInput;
    public float forwardsInput;
    void Start()
    {
        estaQuieto = true;
    }

    // Update is called once per frame
    void Update()
    {

        estaQuieto = forwardsInput == 0;

        horizontalInput = Input.GetAxis("Horizontal");
        forwardsInput = Input.GetAxis("Vertical");

        // Vamos a mover el darro adelante
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * forwardsInput);

        // Esto lo que hace es que cuando es quieto, no se mueva la rotacion. Solo se movera si el vertical se mueve
        if (!estaQuieto)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * velocidadGirar * horizontalInput);
        }
    }
}
