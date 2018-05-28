using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour {
	    public GameObject enermy;
	    private int flag1 =0;
	    private int flag2 =0;



	// Use this for initialization
	void Start () {
	    Instantiate (enermy, new Vector3 (2, 2), Quaternion.identity);
		Instantiate (enermy, new Vector3 (2, -2), Quaternion.identity);
		
	}
	void Update(){
		if(flag2<10){
		if(flag1>50){flag1=0;flag2+=1;
		Vector3 position = new Vector3(Random.Range(3.0f, 4.0f),  Random.Range(-2.6f, 2.6f), 9.8f);
        Instantiate(enermy, position, Quaternion.identity);

		}else{
		flag1+=1;}

	    }
	}

}
