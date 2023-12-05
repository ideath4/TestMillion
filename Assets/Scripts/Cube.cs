using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] Transform CubeOpponent;
    protected ParticleSystem.MainModule mainModule;
    public Transform ParticlesParent;
    public float speed = 1;
    public float particlesLifetime = 1f;
    public float distancePercent = .7f;

    protected void RotateParticles()
    {
        float dist = Vector3.Distance(transform.position, CubeOpponent.position);
        ParticlesParent.LookAt(CubeOpponent);
        mainModule.startLifetime = particlesLifetime;
        mainModule.startSpeed = dist * distancePercent / particlesLifetime;
        //
    }
    public Transform TargetCube;
    public void Move(Vector2Int dir)
    {
        transform.position = transform.position + new Vector3(dir.x, 0, dir.y) * speed * Time.fixedDeltaTime;
    }
}
