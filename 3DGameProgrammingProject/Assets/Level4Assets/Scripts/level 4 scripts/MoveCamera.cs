using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream:3DGameProgrammingProject/Assets/Level4Assets/Scripts/level 4 scripts/MoveCamera4.cs
public class MoveCamera4 : MonoBehaviour
=======
public class MoveCamera : MonoBehaviour
>>>>>>> Stashed changes:3DGameProgrammingProject/Assets/Level4Assets/Scripts/level 4 scripts/MoveCamera.cs
{
    // Start is called before the first frame update
    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
