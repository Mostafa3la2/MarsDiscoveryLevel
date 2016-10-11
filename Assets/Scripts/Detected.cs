using UnityEngine;
using System.Collections;

public class Detected : MonoBehaviour {

	public bool inside;
	void OnTriggerEnter(Collider col){
		if(col.gameObject.name=="Mouse"){
			//Debug.Log(this.gameObject.name+"Detected");
			inside=true;

				//pinpoint.SetActive(true);
		}

	}
}
