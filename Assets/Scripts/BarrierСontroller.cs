using UnityEngine;
using System;

public class BarrierСontroller : MonoBehaviour
{
    public int BarrierType = 1;
    public float amplitude = 30f;
    public float maxSpeed = 5f;
    private Rigidbody m_Rigidbody;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(BarrierType == 1)
        {
            m_Rigidbody.MoveRotation(Quaternion.Euler(new Vector3(0, 0, Mathf.Sin(Time.time * maxSpeed) * amplitude)));
        } else if(BarrierType == 2)
        {
            m_Rigidbody.MoveRotation(Quaternion.Euler(new Vector3(m_Rigidbody.rotation.x, m_Rigidbody.rotation.y, m_Rigidbody.rotation.z + (Time.deltaTime * 10 * maxSpeed))));
        }
    }
}