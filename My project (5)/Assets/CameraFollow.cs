using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public Vector3 offset = new Vector3(0, 3, -3); // Distancia inicial de la cámara
    public float sensitivity = 3.0f; // Sensibilidad del mouse
    public float minY = -40f, maxY = 80f; // Límites verticales

    private float rotationX = 0f, rotationY = 10f; // Valores iniciales de rotación

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Captura la entrada del mouse
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationX += mouseX;
            rotationY -= mouseY;
            rotationY = Mathf.Clamp(rotationY, minY, maxY); // Limita la rotación vertical

            // Calcula la rotación basada en el mouse
            Quaternion rotation = Quaternion.Euler(rotationY, rotationX, 0);

            // Calcula la nueva posición de la cámara
            Vector3 newPosition = player.position - (rotation * Vector3.forward * offset.magnitude) + Vector3.up * offset.y;

            // Aplica la posición y la rotación
            transform.position = newPosition;
            transform.LookAt(player.position + Vector3.up * 1.5f); // Apunta al jugador
        }
    }
}