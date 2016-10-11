using UnityEngine;
using System.Collections;

public class OffPlanet : MonoBehaviour {
	public GameObject crosshair;
	void OnTriggerEnter(Collider col){
		if(col.gameObject.name=="Mouse"){

			//Debug.Log("Hello");
			crosshair.gameObject.GetComponent<SpriteRenderer>().enabled = true;
		}

	}
	void OnTriggerExit(Collider col){
		if(col.gameObject.name=="Mouse"){
			

			crosshair.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
