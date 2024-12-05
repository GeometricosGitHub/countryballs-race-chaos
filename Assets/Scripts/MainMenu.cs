using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject ConfiguracionPanel;
    public GameObject MenuPrincipal;
    public GameObject OpcionesJugar;
    public GameObject MenuNiveles;
    public GameObject MenuTienda;
    public GameObject PanelCodigos;
    public GameObject MenuTutorial;
    public GameObject MenuDivisas;
    public void MenuJugarOpciones()
    {
        MenuPrincipal.SetActive(false);
        OpcionesJugar.SetActive(true);
    }
    public void MenuJugarUnSoloJugadorNiveles()
    {
        Debug.Log("Menu de un solo jugador, elige un nivel");
        SceneManager.LoadScene(1);
    }

    public void MenuNivel1()
    {
        Debug.Log("Nivel 1 seleccionado");
        SceneManager.LoadScene(1);
    }

    public void Tutoriales()
    {
        OpcionesJugar.SetActive(false);
        MenuTutorial.SetActive(true);
    }
    public void SalirTutoriales()
    {
        OpcionesJugar.SetActive(true);
        MenuTutorial.SetActive(false);
    }
    public void VolverMenuPrincipalOpcionesJuegar()
    {
        OpcionesJugar.SetActive(false);
        MenuPrincipal.SetActive(true);
    }

    public void NivelesMenu()
    {
        MenuNiveles.SetActive(true);
        OpcionesJugar.SetActive(false);
    }

    public void VolverMenuPrincipalNiveles()
    {
        MenuNiveles.SetActive(false);
        OpcionesJugar.SetActive(true);
    }

    public void Configuracion()
    {
        ConfiguracionPanel.SetActive(true);
        MenuPrincipal.SetActive(false);
        Debug.Log("Ahora estas en Confuracion");
    }

    public void SalirConfiguracion()
    {
        MenuPrincipal.SetActive(true);
        ConfiguracionPanel.SetActive(false);
        Debug.Log("Ahora estas en el menu principal");
    }

    public void Tienda()
    {
        MenuPrincipal.SetActive(false);
        MenuTienda.SetActive(true);
    }
    public void SalirTienda()
    {
        MenuPrincipal.SetActive(true);
        MenuTienda.SetActive(false);
    }

    public void Codigos()
    {
        PanelCodigos.SetActive(true);
    }
    public void SalirCodigos()
    {
        PanelCodigos.SetActive(false);
    }
    public void Divisas()
    {
        MenuDivisas.SetActive(true);
    }
    public void SalirDivisas()
    {
        MenuDivisas.SetActive(false);
    }
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

    public void ComoManejarTutorial()
    {
        SceneManager.LoadScene(2);
    }
}
