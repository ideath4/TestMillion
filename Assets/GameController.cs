using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]TMPro.TMP_Text distanceText;
    [SerializeField]GameObject Spheres;
    Transform redCube;
    Transform greenCube;
    bool levelEnded = false;
    [SerializeField] float ShowSpheresDistance = 2;
    private void Start()
    {
        redCube = FindObjectOfType<MovingRedCubeScript>().transform;
        greenCube = FindObjectOfType<MovingGreenCube>().transform;
    }
    private void FixedUpdate()
    {
        float distance = Vector3.Distance(redCube.position, greenCube.position);
        distanceText.text = "" +distance;
        switchSpheres(distance);
    }
    void switchSpheres(float distance)
    {
        if (levelEnded)
            return;
        Spheres.SetActive(distance <= ShowSpheresDistance);
        if(distance < 1)
        {
            levelEnded = true;
            SceneManager.LoadScene(1);
        }
    }
}
