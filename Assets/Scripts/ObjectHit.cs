using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mesh;
    Color wallColor = new Color(0f, 1f, 0.5833332f);
    private void OnCollisionEnter(Collision collision)
    {
        mesh = GetComponent<MeshRenderer>();
        if(collision.gameObject.tag == "Player")
        {
            gameObject.tag = "Hit";
            mesh.material.color = Color.red;
        }
    }
}
