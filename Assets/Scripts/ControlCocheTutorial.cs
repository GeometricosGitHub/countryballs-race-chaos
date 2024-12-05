using System.Collections;
using TMPro;
using UnityEngine;

public class ControlCocheTutorial : MonoBehaviour
{
    public bool estaQuieto;

    public float velocidad = 15f;
    public float velocidadGirar = 75f;
    public float horizontalInput;
    public float forwardsInput;

    public TMP_Text text;
    public string cambiarTexto1;

    private bool wPresionada = false; // Para verificar si presionó W
    private bool sPresionada = false; // Para verificar si presionó S

    void Start()
    {
        StartCoroutine("Tutorial");

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

        if (forwardsInput > 0)
        {
            wPresionada = true;
        }

        // Verifica si presionó S
        if (forwardsInput < 0)
        {
            sPresionada = true;
        }
    }

    IEnumerator Tutorial()
    {
        yield return new WaitForSeconds(6);

        cambiarTexto1 = "Primero, presiona la W por un tiempo para ir hacia adelante";
        text.text = cambiarTexto1;
        forwardsInput = 15f;

        yield return new WaitUntil(() => wPresionada);
        text.text = "Ahora, intenta presionar la S para ir hacia atrás.";

        yield return new WaitUntil(() => sPresionada);
        text.text = "¡Buen trabajo! Ahora aprenderas como girar de forma adecuada.";
    }
}

