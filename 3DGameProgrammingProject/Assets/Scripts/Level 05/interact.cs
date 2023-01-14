using UnityEngine;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Canvas interactCanvas;
    [SerializeField] private Material radiusMaterial;
    [SerializeField] private Material inRadiusMaterial;

    private MeshRenderer meshRenderer;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != player) return;
        interactCanvas.enabled = true;
        meshRenderer.material = inRadiusMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject != player) return;
        interactCanvas.enabled = false;
        meshRenderer.material = radiusMaterial;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactCanvas.enabled)
        {
            StartLoading();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            StopLoading();
        }
    }

    private void StartLoading()
    {
        _slider.value = 0;
        _slider.gameObject.SetActive(true);
    }

    private void StopLoading()
    {
        _slider.gameObject.SetActive(false);
    }
}
