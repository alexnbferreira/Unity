using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float mySpeed = 30;
	private float myRange = 70;
	private float startPos;


	// Use this for initialization
	void Start () {
		startPos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
		startPos += Time.deltaTime * mySpeed;
		if (startPos > myRange)
			Destroy(gameObject);
	}


}
