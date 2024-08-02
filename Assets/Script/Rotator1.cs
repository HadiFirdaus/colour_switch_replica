using UnityEngine;

public class Rotator1 : MonoBehaviour {

	public float speed=100f;

	// Update is called once per frame
	void Update () {

		transform.Rotate (0f, 0f, -speed*Time.deltaTime);
		//current position of circle then rotate the cicrle at that position
	}
}
