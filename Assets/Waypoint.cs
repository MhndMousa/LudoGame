using UnityEngine;

public class Waypoints : MonoBehaviour {

	public static Transform[] points;

	// Use this for initialization
	void Awake(){
		points = new Transform[transform.childCount];
		for (int i = 0; i < points.Length; i++) {
			points[i] = transform.GetChild (i);
		}
	}

	void Update() {
		print (Input.GetKey("a"));
		if (Input.GetKeyDown(KeyCode.Space))
			print("space key was pressed");

	}

}
