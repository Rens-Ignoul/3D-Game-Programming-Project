using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class move_Lvl2 : MonoBehaviour
{
    public float speed = 75f;
    private int score = 0;
    public TMP_Text scoreText;
    public TMP_Text GameOverScoreText;
    public TMP_Text achivementText;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;
    }
    void Update()
    {
        speed = 75f;
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * (speed / 2));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1 * Time.deltaTime*speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1 * Time.deltaTime*speed, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 100000f;
        }
    }

    string calculateAchivement()
    {
        if (score <30) return "failed";
        if (score <30&&score<40) return "just enough trash collected";
        if (score <40&&score<50) return "Good Job";
        if (score == 50) return "Amazing, you collectd all the trash";
        else return "";
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "trash")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString();
            GameOverScoreText.text = "Final Score: " + score.ToString();
            achivementText.text = calculateAchivement();
        }
    }
}
