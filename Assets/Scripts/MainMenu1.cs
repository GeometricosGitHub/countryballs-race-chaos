using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class MainMenu1 : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject configuracionPausa;
    public void MenuPausaTeclado()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuPausaBoton();
        }
    }
    public void Configuracion()
    {
        configuracionPausa.SetActive(true);
    }

    public void VolverPausa()
    {
        configuracionPausa.SetActive(false);
    }
    public void MenuPausaBoton()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1;
        menuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SalirJuego()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
