using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBoxTrigger : MonoBehaviour {

public GameObject enteredCard;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Card")
		{
			enteredCard = col.gameObject;

			switch (enteredCard.GetComponent<CardDestination>().destination)

			{
				case 0: 
					print("Go to first level");
					break;
				case 1:
					print("Go to second level");
					break;
				case 2:
					print("Go to third level");
					break;
				case 3: 
					print("Go to fourth level");
					break;
				case 4:
					print("Go to fifth level");
					break;
				default:
					print("Something is wrong");
					break;

			}
		}
	}
}
