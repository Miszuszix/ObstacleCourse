using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3;
    MeshRenderer mesh;
    Rigidbody body;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();
        mesh.enabled = false;
        body.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            body.useGravity = true;
            mesh.enabled = true;
        }
    }
}
