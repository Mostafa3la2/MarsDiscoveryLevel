using UnityEngine;
using System.Collections;

public class NavigatorControl : MonoBehaviour {
	public float distance=9f;
	// Use this for initialization
	void Start () {
		MeshRenderer render = gameObject.GetComponentInChildren<MeshRenderer>();
		

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 temp = Input.mousePosition;
		temp.z =distance; // Set this to be the distance you want the object to be placed in front of the camera.
		this.transform.position = Camera.main.ScreenToWorldPoint(temp);
		//Debug.Log(transform.position);

	}
}
