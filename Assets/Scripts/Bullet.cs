using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float Speed = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Character")
		{
			Destroy(gameObject);
			other.gameObject.SendMessage("Damage");
		}
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(new Vector3(-1*Speed, 0, 0));
	}
}
