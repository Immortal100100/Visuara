using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform Earth;
    public float rotatespeed=80f;

    void Update()
    {
        Earth.Rotate(Vector3.up,rotatespeed*Time.deltaTime);
    }
}
