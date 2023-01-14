using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class startLevel05 : MonoBehaviour
{
  
    public TimerLevel05 timer;
    public PointsLevel05 points;
    public int time;
    public Canvas mainCanvas;
    public Canvas endcanvas;
    public Canvas interactCanvas;
    public Canvas resumeCanvas;
    public playerMoveLevel05 playerMove;
    public followPlayerLevel05 followPlayer;



    // Start is called before the first frame update
    void Start()
    {
        timer.resetTimer(0);
        Time.timeScale = 0;

    }
   public void restart()
    {
        points.resetPoints();
        timer.resetTimer(120);
        playerMove.resetPosition();
        followPlayer.resetPosition();
        Time.timeScale = 1;
        endcanvas.enabled = false;
        interactCanvas.enabled = false;
        resumeCanvas.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer.getTimeRemaining() <= 0)
        {
            endcanvas.enabled = true;
        }
    }
    public static Vector3 getRandomPosition()
    {
        float minX = -8; // minimum x position
        float maxX = 9f; // maximum x position
        float minZ = -13f; // minimum z position
        float maxZ = 10f; // maximum z position
        float yPos = 33.5f;

        float x = UnityEngine.Random.Range(minX, maxX);
        float z = UnityEngine.Random.Range(minZ, maxZ);
        return new Vector3(x, yPos, z);
    }

  
}
