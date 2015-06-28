using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	float turnSpeed = 20;
	private Muzzle muzzleObj;

	// Use this for initialization
	void Start () {
		muzzleObj = GetComponentInChildren<Muzzle> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void fire(){
		muzzleObj.fire ();
	}
}
