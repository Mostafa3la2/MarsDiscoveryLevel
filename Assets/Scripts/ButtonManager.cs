using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {
	public GameObject label;
	public GameObject label2;
	public GameObject label3;
	// Use this for initialization
	public void OnClick(){
		label.SetActive(true);
		label2.SetActive(false);
		label3.SetActive(false);

	}
}
