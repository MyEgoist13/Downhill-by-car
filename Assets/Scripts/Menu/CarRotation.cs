using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotation : MonoBehaviour
{
    public float rotationSpeed;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
    }
}
