using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class forplayer : MonoBehaviour
{
    Rigidbody2D m_Rigidbody2D;
    float m_Speed;
	int counter=0;

	public GameObject bullet;
	public Text mtext;
	private int hp = 5;
	private Animator m_animator;
    void Start()
    {
        //Fetch the RigidBody from the GameObject
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_animator=GetComponent<Animator>();
  
        m_Speed = 0.1f;
    }
    void OnTriggerEnter2D(Collider2D other){
    	if(other.gameObject.CompareTag("enermy")){

    	hp-=1;
    	if(hp<=0){m_animator.SetTrigger("deadflag");Destroy(gameObject,2);}else{m_animator.SetTrigger("hitflag");}

    }

    }

    void Update()
    {   mtext.text="hp  "+hp.ToString();
		if(counter>20){counter=0;GameObject wow3 = Instantiate (bullet, new Vector3(m_Rigidbody2D.position.x,m_Rigidbody2D.position.y,9.9f), Quaternion.identity);}
		counter+=1;
        //Press the Up arrow key to move the RigidBody upwards
        if (Input.GetKey(KeyCode.UpArrow)){m_Rigidbody2D.position += Vector2.up * m_Speed;}
        if (Input.GetKey(KeyCode.LeftArrow)){m_Rigidbody2D.position += Vector2.left * m_Speed;}
        if (Input.GetKey(KeyCode.RightArrow)){m_Rigidbody2D.position += Vector2.right * m_Speed;}
        if (Input.GetKey(KeyCode.DownArrow)){m_Rigidbody2D.position += Vector2.down * m_Speed;}

    }
}