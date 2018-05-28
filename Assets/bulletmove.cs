using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    Rigidbody2D m_Rigidbody2D;
    float m_Speed;

    void Start()
    {

        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        m_Speed = 3.0f;

    }

    void Update()
    {

            m_Rigidbody2D.velocity = Vector2.right * m_Speed;
        if(m_Rigidbody2D.position.x>3){Destroy(gameObject, 1);}
    }
}