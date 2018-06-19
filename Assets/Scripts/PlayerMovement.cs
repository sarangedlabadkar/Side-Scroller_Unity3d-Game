using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour{
		private Rigidbody2D _rigidBody;
		private Animator _anim;
		public float speed=10;
		private float hInput=0;
		public bool isGrounded;
		void Start(){
			_rigidBody=GetComponent<Rigidbody2D>();
			_anim=GetComponent<Animator>();
		}
		void Update(){
			hInput=Input.GetAxisRaw("Horizontal");
			if(hInput==1)
				transform.localScale=new Vector2(0.5f,0.5f);
			else if(hInput==-1)
				transform.localScale=new Vector2(-0.5f,0.5f);			
			if(Input.GetButtonDown("Jump") && isGrounded)
				_rigidBody.velocity=new Vector2(_rigidBody.velocity.x
				, 5);	
			AnimationController();
		}
		void AnimationController(){
				if(isGrounded){
					if(Mathf.Abs(_rigidBody.velocity.x)>0.1f){
						_anim.SetInteger("AnimPlayer",1);
					}else{
						_anim.SetInteger("AnimPlayer",0);
					}
				}else{
					_anim.SetInteger("AnimPlayer",3);
				}
		}
		void FixedUpdate(){
				Vector2 velocity=_rigidBody.velocity;
				if(isGrounded)
					velocity.x=Mathf.Lerp(velocity.x,hInput*speed,Time.deltaTime*10);
				_rigidBody.velocity=velocity;
		}
		void OnCollisionStay2D(Collision2D col){
			if(col.gameObject.tag=="Ground")
				isGrounded=true;
		}
		void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Ground")
			isGrounded = false;
	}

	void OnCollisionEnter2D (Collision2D gameover )

		{

		if (gameover.gameObject.tag == "Gameover")
			SceneManager.LoadScene (4);
		else if (gameover.gameObject.tag == "NextLevel")
			SceneManager.LoadScene (2);
		else if (gameover.gameObject.tag == "NextLevel1")
			SceneManager.LoadScene (3);
		else if (gameover.gameObject.tag == "NextLevel2")
			SceneManager.LoadScene (5);
		
		}
	





	
	
	}

		
 		



















