using System.Collections;
using UnityEngine;

public class flashingLight : MonoBehaviour
{
    public Material redMaterial;
    public Material transparentMaterial;

    private Renderer renderer;
    private bool active;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = transparentMaterial;
    }

    void Update()
    {

    }

    public void useLight(bool active=false)
    {
        if (active)
        {
            renderer.material = redMaterial;
        }
        else{
            renderer.material = transparentMaterial;
        }
    }
    
 
}