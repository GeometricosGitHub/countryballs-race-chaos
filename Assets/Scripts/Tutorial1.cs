using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial1 : MonoBehaviour
{
    public TMP_Text text;
    public string cambiarTexto1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cambiarTexto1 = cambiarTexto1 + "Primero, presiona la W por un tiempo para ir hacia adelante";
        text.text = cambiarTexto1.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
