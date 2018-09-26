using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using TMPro;

public class Lanes : MonoBehaviour
{

	public GameObject Lane;
	public GameObject Mid;
	public float X;
	public float Y;
	public float Timer;
	public Player1move Player1;
	public Player2move Player2;
	public TextMeshProUGUI EndText;
	public TextMeshProUGUI RestartText;


	// Use this for initialization
	void Start ()
	{

		Timer = 60.0f;
		
		for (int i = 0; i < 15; i++)
		{
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+1, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+2, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+3, 0), Quaternion.identity);
			Instantiate(Mid, new Vector3(X - i * 2.0F, Y+4, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+5, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+6, 0), Quaternion.identity);
			Instantiate(Lane, new Vector3(X - i * 2.0F, Y+7, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		Timer -= Time.deltaTime;
		if(Timer < 0)
		{
		
			Debug.Log("END");
			Player1.Move = false;
			Player2.Move = false;
			RestartText.text = "Press R to restart!";
			Player1.transform.position = new Vector3(5.75f, -4.5f,-3);
			Player2.transform.position = new Vector3(-5.75f, -4.5f,-3);

			if (Player1.Score > Player2.Score)
			{
				Debug.Log("Player 1 Win!");
				EndText.text = "Player 1 Wins!";
			}

			else if (Player2.Score > Player1.Score)
			{
				Debug.Log("Player 2 Win!");
				EndText.text = "Player 2 Wins!";
			}
			
			else
			{
				Debug.Log("Draw!");
				EndText.text = "Draw!";
			}
		}

		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
