using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Color newColor = Color.green;

    private Material playerMaterial;

    void Start()
    {
        playerMaterial = GetComponent<Renderer>().material;

        playerMaterial.color = newColor;
    }
}
