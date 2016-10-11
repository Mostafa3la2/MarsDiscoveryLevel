using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	public float x;
	public float RotationSpeed = 1000;
	public GameObject location;
	public GameObject pinpoint;
	public GameObject mouse;
	public float factor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(location.GetComponent<Detected>().inside&&Input.GetKeyDown(KeyCode.Tab)){

			pinpoint.SetActive(true);
			pinpoint.transform.position=new Vector3(mouse.transform.position.x,mouse.transform.position.y,pinpoint.transform.position.z);
			StartCoroutine(ChangeLevel());
			//location.GetComponent<Detected>().inside=false;
		}
		if(Input.GetAxis("Fire1")>0){
			
			transform.Rotate(0,(Input.GetAxis("Mouse X") * RotationSpeed *10), 0, Space.World);}

	}
	IEnumerator ChangeLevel(){
		float fadeTime=GameObject.Find("Transition").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
		Application.LoadLevel(Application.loadedLevel+1);


	}
}
