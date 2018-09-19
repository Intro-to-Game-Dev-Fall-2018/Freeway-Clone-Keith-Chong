using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CarMovement : MonoBehaviour
{

	public float Speed;
	public float Startx;
	public float Starty;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3(Speed, 0);
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	
	{
		if (other.gameObject.CompareTag("Finish"))
		{
			transform.position = new Vector3(Startx, Starty,-2);
			Debug.Log(Speed);
		}
	}
}
