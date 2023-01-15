using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform player;
    public Vector3 startPosition;
    public Vector3 finishPosition;
    public Slider progressSlider;
    public float maxProgress = 100f; // this could be set to a value that represent your max progress

    void Start()
    {
        progressSlider.minValue = 0f;
        progressSlider.maxValue = maxProgress;
        progressSlider.value = 0f;
    }

    void Update()
    {
        float progress = Vector3.Distance(player.position, finishPosition);
        float maxDistance = Vector3.Distance(finishPosition, startPosition);
        progress = 1 - (progress / maxDistance);
        progress *= maxProgress;
        progressSlider.value = progress;
    }
}
