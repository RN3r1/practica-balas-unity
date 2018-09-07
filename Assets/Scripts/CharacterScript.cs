using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

	public Animator AnimatorController;
	public int Life = 10;
	private bool IsAlive = true;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10,0,100,50),new
			GUIContent("P1: "+Life));
	}

	// Update is called once per frame
	public float rotationSpeed = 10.0F;
	void Update() {
		if (IsAlive)
		{
			float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
			rotation *= Time.deltaTime;

			float yAxis = Input.GetAxis("Vertical") * rotationSpeed;
			yAxis *= Time.deltaTime;
		
			transform.Translate(0, yAxis, 0);
		
			transform.Translate(rotation, 0, 0);
			AnimatorController.SetFloat("Speed", Mathf.Abs(rotation));
		}
		
	}

	public void Damage()
	{
		if (Life > 0)
		{
			Life--;
			if (Life == 0)
			{
				IsAlive = false;
				AnimatorController.SetBool("isAlive", false);
			}
		}
	
	}
}
