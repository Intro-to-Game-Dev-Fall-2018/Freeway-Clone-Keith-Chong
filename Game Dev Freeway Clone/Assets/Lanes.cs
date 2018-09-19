using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanes : MonoBehaviour
{

	public GameObject Lane;
	public GameObject Mid;
	public float X;
	public float Y;


	// Use this for initialization
	void Start () {
		
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
		
	}
}
