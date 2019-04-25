using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character : MonoBehaviour
{
   private Rigidbody rb;
   private float speed;
   
   public Text healthText;
   public Text expText;
   public Text lvlText;
   
   private int revolver;
   private int exp = 0;
   private int health;
   private int level =1;
   
   
   public Transform shotLocation;
   public GameObject bulletOne;
   
   
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
	health = 10;
	 revolver = 200;
	 SetHealthText ();
	 SetlvlText();
	 SetExpText ();
    }

    void Update(){
		speed = 0.1f;
	//Debug.Log(Input.mousePosition);
		/*movement */
		if(Input.GetKey("w")){
			transform.Translate(0.0f,0f,1*speed);
		}
		if(Input.GetKey("s")){
			transform.Translate(0.0f,0f,-1*speed);
		}
		if(Input.GetKey("a")){
			transform.Translate(-1*speed,0f,0f);
		}
		if(Input.GetKey("d")){
			transform.Translate(1*speed,0f,0f);
		}
		
		
		/* Shoot */
		if(Input.GetKey("space") && revolver > 100){
			Instantiate(bulletOne, shotLocation.position,shotLocation.rotation);
			revolver = 0;
		}
		revolver++;
	}
	
    void FixedUpdate() //for physics
    {
	
    }
	
	
	void SetHealthText ()
	{
		healthText.text = "Health: " + health.ToString ();
	}
	
		void SetExpText ()
	{
		expText.text = "Exp: " + exp.ToString ();
	}
	
		void SetlvlText ()
	{
		lvlText.text = "Lv: " + level.ToString ();
	}

}
