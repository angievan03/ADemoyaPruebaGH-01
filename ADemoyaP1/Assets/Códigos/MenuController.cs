using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void CargarEscena()
    {
        SceneManager.LoadScene("Escenario"); 
    }

    public void SalirJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}
