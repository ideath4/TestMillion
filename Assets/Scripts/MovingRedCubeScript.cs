using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRedCubeScript : Cube
{
    // Start is called before the first frame update
    void Start()
    {
        TargetCube = FindObjectOfType<MovingGreenCube>().transform;
        mainModule = ParticlesParent.GetComponent<ParticleSystem>().main;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        RotateParticles();
        Vector2Int TotalDirection = GetMoveDirection();
        Move(TotalDirection);
    }
    protected Vector2Int GetMoveDirection()
    {
        Vector2Int res = new Vector2Int();

        if (Input.GetKey(KeyCode.A))
            res += Vector2Int.left;
        if (Input.GetKey(KeyCode.D))
            res += Vector2Int.right;
        if (Input.GetKey(KeyCode.W))
            res += Vector2Int.up;
        if (Input.GetKey(KeyCode.S))
            res += Vector2Int.down;
        return res;
    }
}
