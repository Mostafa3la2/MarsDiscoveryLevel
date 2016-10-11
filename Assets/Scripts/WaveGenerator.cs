using UnityEngine;
using System.Collections;

public class WaveGenerator : MonoBehaviour {
	public GameObject location;
	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	public int lengthOfLineRenderer = 50;
	float factor;
	void Start() {
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
		lineRenderer.SetColors(c1, c2);
		lineRenderer.SetWidth(0.05F, 0.05F);

		lineRenderer.SetVertexCount(lengthOfLineRenderer);

	}
	void Update() {
		factor=1/location.GetComponent<Indicator>().Distance();
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		int i = 0;
		while (i < lengthOfLineRenderer) {
			//Vector3 pos = new Vector3(-15+(i * .5F),-2+(factor* Mathf.Sin(i + Time.time)), 0);
			Vector3 pos = new Vector3(-15+(i * 0.5F), Mathf.Sin(factor*i + Time.time), 0);
			lineRenderer.SetPosition(i, pos);
			i++;
		}

	}
}
