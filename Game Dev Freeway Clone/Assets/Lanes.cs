using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Lanes : MonoBehaviour
{

	public GameObject Lane;
	public GameObject Mid;
	public float X;
	public float Y;
	public float Timer;
	public GameObject Player1;
	public GameObject Player2;


	// Use this for initialization
	void Start ()
	{

		Timer = 5.0f;
		
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
		}

		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
