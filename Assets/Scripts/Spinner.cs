using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speed = 0.75f;
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
