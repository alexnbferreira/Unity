using UnityEngine;
using System.Collections;

public class Muzzle : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void fire(){
		Debug.Log ("Muzzle Firing!");
		Instantiate (bullet, this.transform.position, this.transform.rotation);
	}
}
