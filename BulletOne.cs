using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOne : MonoBehaviour
{
   private int die;
   private int u;
   private int d;
   private int l;
   private int r;
    void Start()
    {
        die =0;
		u = 0;
		d = 0;
		l = 0;
		r = 1;
    }


    void Update()
    {
		
		if(Input.GetKey("up")){
			u =1;
			d = 0;
			l = 0;
			r =0;
		}
		if(Input.GetKey("down")){
			d = 1;
			u =0;
			r=0;
			l=0;
		}
		if(Input.GetKey("left")){
			l = 1;
			u=0;
			r=0;
			d=0;
		}
		if(Input.GetKey("right")){
			r =1;
			u=0;
			l=0;
			d=0;
			
		}
		if(l ==1){
        transform.Translate(-0.20f,0f,0f);
		}
		if(r ==1){
        transform.Translate(0.20f,0f,0f);
		}
		if(u ==1){
        transform.Translate(0f,0f,0.20f);
		}
		if(d ==1){
        transform.Translate(0f,0f,-0.20f);
		}
		
		if(die == 100){
			Destroy(gameObject);
		}
		die++;
    }
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			Destroy(gameObject);
		}
	}
}
