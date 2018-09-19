using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2move : MonoBehaviour {

	public float Speed;
	public int Score;
	public TextMeshProUGUI ScoreText;
	
	// Use this for initialization
	void Start () {
		Score = 0;
		ScoreText.text = "Score:" + Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W))
		{
			transform.position += new Vector3(0, Speed);
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += new Vector3(0, -Speed);
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
			transform.position = new Vector3(-5.75f, -4.5f,-3);
			Debug.Log(Speed);
			Score += 1;
			ScoreText.text = "Score:" + Score.ToString();
		}
		
		if (other.gameObject.CompareTag("Respawn"))
		{
			transform.position = new Vector3(-5.75f, -4.5f,-3);
			Debug.Log(Speed);
		}
	}
}

