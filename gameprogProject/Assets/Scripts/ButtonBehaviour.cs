using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonBehaviour : MonoBehaviour
{
    public AudioSource wrong;
    public AudioSource correct;
    public TMP_Text textMeshPro;
    public TMP_Text scoreChange;
    public GameObject questionObject;
    public GameObject imageObject;
    private Rigidbody rigid;
    private ScoreManager score;
    private Timer timer;

    void Awake()
    {
        score = GetComponent<ScoreManager>();
        timer = GetComponent<Timer>();
        
    }
    void Update()
    {
        Timer.remainingSeconds += 1 * Time.deltaTime; //zorgt ervoor dat tijd niet sneller gaat afnemen bij trigger
    }

    public void WrongAnswer()
    {
        Cursor.lockState = CursorLockMode.Locked;
        wrong.Play();
        textMeshPro.text = "Wrong answer!";
        timer.DecreaseTime();
        StartCoroutine(DeleteQuestionAndImage());
    }

    public void RightAnswer()
    {
        Cursor.lockState = CursorLockMode.Locked;
        correct.Play();
        textMeshPro.text = "That's correct!";
        timer.IncreaseTime();
        score.Collision();
        StartCoroutine(DeleteQuestionAndImage());
    }

    IEnumerator DeleteQuestionAndImage()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(questionObject);
        imageObject.SetActive(false);
        rigid.constraints &= ~RigidbodyConstraints.FreezePosition;
    }
}

