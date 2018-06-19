using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float smoothing=2.0f;
	public Transform target;
	public Vector2 offset;
	
	void Start(){
		target=GameObject.FindWithTag("Player").transform;
		offset=transform.position-target.position;
	}
	void FixedUpdate(){
		Vector3 targetPos=new Vector3(target.transform.position.x,transform.position.y,transform.position.z);
		targetPos.x=targetPos.x+offset.x;
		transform.position=Vector3.Lerp(transform.position,targetPos,Time.deltaTime*smoothing);
	}
}
