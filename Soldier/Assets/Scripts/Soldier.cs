using UnityEngine;
using System.Collections;

public class Soldier : MonoBehaviour {

	private float turnSpeed = 20;
	public Transform target;
	private float reloadTime = 2;
	private float lastShot;
	public Transform gun;
	public Gun gunObj;

	// Use this for initialization
	void Start () {
		Debug.Log ("Initializing Soldier");
		lastShot = 0;

		gun = this.transform.GetChild (0).GetChild(0);
		gunObj = GetComponentInChildren<Gun> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			float step = turnSpeed * Time.deltaTime;
			Vector3 dir = target.transform.position - gun.position;
			Vector3 horDir = dir;
			horDir.y = 0;
			transform.rotation = Quaternion.Lerp (gun.rotation, Quaternion.LookRotation(horDir), step);
			transform.GetChild(0).rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), step);
			lastShot += Time.deltaTime;
			if (lastShot > reloadTime){
				fire();
				lastShot = 0;
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Enemy" && !target) {
			target = other.attachedRigidbody.gameObject.transform;
			Debug.Log ("Target adquired at " + other.transform.position.x +
				"and " + other.transform.position.z);
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.tag == "Enemy" && target && target == other.attachedRigidbody.gameObject.transform)
			target = null;
	}

	void fire(){
		Debug.Log ("Fire!");
		gunObj.fire ();
	}
}
