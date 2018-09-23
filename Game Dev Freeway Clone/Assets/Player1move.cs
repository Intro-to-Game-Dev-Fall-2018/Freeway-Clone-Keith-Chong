using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using TMPro;
using UnityEngine.UI;

public class Player1move : MonoBehaviour {

	public float Speed;
	public bool Move;
	public int Score;
	public TextMeshProUGUI ScoreText;
	public AudioSource Crash;
	public AudioSource Win;
	
	// Use this for initialization
	void Start ()
	{
		Score = 0;
		ScoreText.text = "Score:" + Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, Speed);
			Move = true;
			//Debug.Log(Move);
		}
		
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, -Speed);
			Move = true;
			//Debug.Log(Move);
		}
		
		Vector3 pos = transform.position;
		if (transform.position.y < -4.5f)
			pos.y = -4.5f;
		transform.position = pos;        			
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			transform.position = new Vector3(5.75f, -4.5f,-3);
			Move = false;
			Score += 1;
			ScoreText.text = "Score:" + Score.ToString();
			Debug.Log(Score);
			Win.Play ();
		}
		
		if (other.gameObject.CompareTag("Respawn"))
		{
			transform.position = new Vector3(5.75f, -4.5f,-3);
			Crash.Play ();
			//Debug.Log(Speed);
		}
	}
}
