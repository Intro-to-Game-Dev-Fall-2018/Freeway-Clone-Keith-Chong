using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using TMPro;
using UnityEngine.Experimental.U2D;
using UnityEngine.UI;

public class Player1move : MonoBehaviour {

	public float Speed;
	public bool Move;
	public int Score;
	public TextMeshProUGUI ScoreText;
	public AudioSource Crash;
	public AudioSource Win;
	public Sprite Psprite;
	public Sprite Pmove;
	public Animator Animation;
	public Rigidbody2D Rgbd;
	public float Timer;
	public float Pause;
	public float Lives;
	public TextMeshProUGUI LivesText;
	
	// Use this for initialization
	void Start ()
	{
		Move = true;
		Score = 0;
		ScoreText.text = "Score:" + Score.ToString();
		LivesText.text = "Lives:" + Lives.ToString();
		Pause = 0.1f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Move == true)
		{
			if (Input.GetKey(KeyCode.UpArrow))
			{
				//transform.position += new Vector3(0, Speed);
            	//Debug.Log(Move);
				Rgbd.AddForce(new Vector2(0,Speed), ForceMode2D.Force);
				
				Timer -= Time.deltaTime;
				
				if (Timer < 0 && GetComponent<SpriteRenderer>().sprite == Pmove)
                    			            
				{
					GetComponent<SpriteRenderer>().sprite = Psprite;
					Timer = Pause;

				}
				
				if (Timer < 0 && GetComponent<SpriteRenderer>().sprite == Psprite)
                    			            
				{
					GetComponent<SpriteRenderer>().sprite = Pmove;
					Timer = Pause;

				}

				//if (GetComponent<SpriteRenderer>().sprite == Psprite)
				//{
				//	GetComponent<SpriteRenderer>().sprite = Pmove;
				//}

			}
			
            		
        if (Input.GetKey(KeyCode.DownArrow))
        	{
        		//transform.position += new Vector3(0, -Speed);
     			//Debug.Log(Move);
		        Rgbd.AddForce(new Vector2(0,-Speed), ForceMode2D.Force);
		        
		        Timer -= Time.deltaTime;
				
		        if (Timer < 0 && GetComponent<SpriteRenderer>().sprite == Pmove)
                    			            
		        {
			        GetComponent<SpriteRenderer>().sprite = Psprite;
			        Timer = Pause;

		        }
				
		        if (Timer < 0 && GetComponent<SpriteRenderer>().sprite == Psprite)
                    			            
		        {
			        GetComponent<SpriteRenderer>().sprite = Pmove;
			        Timer = Pause;

		        }
        	}
            		
            		Vector3 pos = transform.position;
            		if (transform.position.y < -4.5f)
            			pos.y = -4.5f;
            		transform.position = pos;   
		}  			
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			transform.position = new Vector3(5.75f, -4.5f,-3);
			Score += 1;
			ScoreText.text = "Score:" + Score.ToString();
			Debug.Log(Score);
			Rgbd.velocity = Vector2.zero;
			Win.Play ();
		}
		
		if (other.gameObject.CompareTag("Respawn"))
		{
			transform.position = new Vector3(5.75f, -4.5f,-3);
			Rgbd.velocity = Vector2.zero;
			Lives -= 1;
			LivesText.text = "Lives:" + Lives.ToString();
			Crash.Play ();
			//Destroy(gameObject);
			//Debug.Log(Speed);
		}
	}
}
