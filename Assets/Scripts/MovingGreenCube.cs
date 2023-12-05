using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGreenCube : Cube
{
    private void Start()
    {
        TargetCube = FindObjectOfType<MovingRedCubeScript>().transform;
        mainModule = ParticlesParent.GetComponent<ParticleSystem>().main;

    }
    private void FixedUpdate()
    {
        RotateParticles();
        Vector2Int TotalDirection = GetMoveDirection();
        Move(TotalDirection);
    }

    protected Vector2Int GetMoveDirection()
    {
        Vector2Int res = new Vector2Int();

        if (Input.GetKey(KeyCode.LeftArrow))
            res += Vector2Int.left;
        if (Input.GetKey(KeyCode.RightArrow))
            res += Vector2Int.right;
        if (Input.GetKey(KeyCode.UpArrow))
            res += Vector2Int.up;
        if (Input.GetKey(KeyCode.DownArrow))
            res += Vector2Int.down;
        return res;
    }
}
