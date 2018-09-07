using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public GameObject Bullet;

	public GameObject BulletEmissor;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("Shoot", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Shoot()
	{
		Instantiate(Bullet, BulletEmissor.transform.position, Quaternion.identity);
	}
	
}
