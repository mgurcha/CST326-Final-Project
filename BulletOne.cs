using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOne : MonoBehaviour
{
private int die;
private int up;
private int down;
private int left;
private int right;
void Start()
{
	die =0;
	up = 0;
	down = 0;
	left = 0;
	right = 1;
}
void Update()
{
if(Input.GetKey("up")){
	up = 1;
	down = 0;
	left = 0;
	right =0;
}
if(Input.GetKey("down")){
	down = 1;
	up =0;
	right=0;
	left=0;
}
if(Input.GetKey("left")){
	left = 1;
	up=0;
	right=0;
	down=0;
}
if(Input.GetKey("right")){
	right=1;
	up=0;
	left=0;
	down=0;

}
if(left ==1){
	transform.Translate(-0.20f,0f,0f);
}
if(right ==1){
	transform.Translate(0.20f,0f,0f);
}
if(up ==1){
	transform.Translate(0f,0f,0.20f);
}
if(down ==1){
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
