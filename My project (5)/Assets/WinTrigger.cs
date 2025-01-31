using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winText; // Objeto del texto que aparecerá al ganar

    void Start()
    {
        // Aseguramos que el texto esté desactivado al iniciar
        winText.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Mensaje en la consola para verificar si la colisión se detecta
        Debug.Log("El jugador ha tocado la meta");

        // Verifica si el objeto que colisionó tiene el tag "Player"
        if (other.CompareTag("Player"))  
        {
            // Activa el letrero de victoria
            winText.SetActive(true);
        }
    }
}