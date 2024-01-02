using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Color newColor;
    private Material player;

    void Start()
    {
        player = GetComponent<Renderer>().material;
        player.color = newColor;
    }
}
