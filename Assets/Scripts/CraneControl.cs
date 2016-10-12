using UnityEngine;
using System.Collections;

public class CraneControl : MonoBehaviour {

	public GameObject rotationAxis;
	public GameObject pulley;
	public GameObject d;

	public float rotationSpeed = 90/5;
	public float xTranslation = 15/5;
	public float yTranslation = 15/5;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate() {
		rotationAxis.GetComponent<Transform>().Rotate(Vector3.up * Input.GetAxis ("Horizontal") * Time.deltaTime * rotationSpeed);
		pulley.GetComponent<Transform>().Translate (Vector3.left * Input.GetAxis ("Vertical") * Time.deltaTime * xTranslation);
		d.GetComponent<Transform> ().Translate (Vector3.up * Input.GetAxis ("WTF") * Time.deltaTime * yTranslation);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
