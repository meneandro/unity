using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // Material nuevo que quieres asignar

    void Start()
    {
        // Obtener el MeshRenderer y cambiar su material
        GetComponent<Renderer>().material = newMaterial;
    }
}