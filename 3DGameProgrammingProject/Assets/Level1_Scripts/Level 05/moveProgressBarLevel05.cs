using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class moveProgressBarLevel05 : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    private KeyCode key = KeyCode.E; // the key to press to fill the slider
    public float fillTime = 500f;// the time it takes to fill the slider
    public GameObject solarPanelReady;
    public Animator animator;
    public TMP_Text keyText;
    public PointsLevel05 points;
    public Canvas interactCanvas;
    // private VisualElement _slider;

    private float startTime; // the time when the slider started filling
    private bool isFilling = false; // flag to track if the slider is currently filling
    private bool gameObjectReplaced = false;

    



    private void Start()
    {
        GameObject textObject = GameObject.Find("Text"); // find the GameObject named "Text"                                                        // TMP_Text pointstext = textObject.GetComponent<TMP_Text>(); // get the TMP_Text

    }
    void Update()
    {
        // if the key is pressed and the slider is not currently filling, start filling the slider
        if (Input.GetKeyDown(key) && !isFilling && interactCanvas.enabled)
        {
            startTime = Time.time;
            isFilling = true;
            Color color;
            ColorUtility.TryParseHtmlString("#8fbc8f", out color);
            keyText.color = color;
        }
        if (Input.GetKeyUp(key) && isFilling)
        {
            isFilling = false;
            keyText.color = Color.white;
        }

        // if the slider is currently filling, update its value
        float elapsedTime = Time.time - startTime;
        if (isFilling)
        {
            //_slider.style.width = elapsedTime / fillTime * 100;
            slider.value = elapsedTime / fillTime * 100;
            animator.Play("m_melee_combat_attack_A");
            // if the slider has finished filling, reset the flag and value
            slider.onValueChanged.AddListener(OnSliderValueChanged);
        }
        else if (!Input.GetKey(key))  // added this check
        {
            slider.value = Mathf.Lerp(slider.value, 0, Time.deltaTime * 1);

        }
    }
    private void OnSliderValueChanged(float value)
    {
        // Check if the slider is completely filled
        if (value == 1)
        {
            // Destroy the game object
            if (!gameObjectReplaced)
            {
                Instantiate(solarPanelReady, gameObject.transform.position, Quaternion.identity);
                gameObjectReplaced = true;
                points.addPoint();
                slider.value = 0;
                transform.position = startLevel05.getRandomPosition();
                StartCoroutine(ChangeBoolAfterTwoSeconds());
            }
        }

    }
   IEnumerator ChangeBoolAfterTwoSeconds()
    {
        yield return new WaitForSeconds(2f);
        gameObjectReplaced = !gameObjectReplaced;
    }
}