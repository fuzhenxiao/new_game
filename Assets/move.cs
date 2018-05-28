using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D m_Rigidbody2D;
    float m_Speed;
    private int hp=1;
    private Animator m_animator;

    void Start()
    {
        //Fetch the RigidBody from the GameObject
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_Speed = 1.0f;
        m_animator=GetComponent<Animator>();
    }

void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("bullet")){
        hp-=1;
        if(hp<=0){m_animator.SetTrigger("enermydeadflag");m_Speed = 0f;Destroy(gameObject,2);}else{m_animator.SetTrigger("enermyhitflag");}

    }

    }


    void Update()
    {


            m_Rigidbody2D.velocity = Vector2.left * m_Speed;
        
    }
}