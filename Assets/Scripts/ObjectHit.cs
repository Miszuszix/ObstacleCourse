using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mesh;
    Color wallColor = new Color(0f, 1f, 0.5833332f);
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("An object that touched " + this.name + " is: " +
            collision.gameObject.name);
        mesh = GetComponent<MeshRenderer>();
        if (mesh.material.color != Color.red)
        {
            mesh.material.color = Color.red;
        }
        else { mesh.material.color = wallColor; }
    }
}
