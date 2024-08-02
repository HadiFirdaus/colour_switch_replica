using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jump=10f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public Color colorCyan;
	public Color colorRed;
	public Color colorChocolate;
	public Color colorYellow;

	public string currentColour;

	void Start(){
		RandomColour ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonDown (0)) {
			rb.velocity = Vector2.up * jump;
		}

		Exit ();
	}

	void OnTriggerEnter2D(Collider2D col){
		//Debug.Log (col.tag);

		if(col.tag == "ColourChanger"){	//change colour of player when hit colourChanger

			RandomColour ();
			Destroy (col.gameObject);	//destroy colourChanger
			return;	//wont game over
		}

		if (col.tag != currentColour) {	//langar warna bertentangan
			Debug.Log ("Game Over!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void RandomColour(){
		int index = Random.Range (0, 3);

		switch (index) {
		case 0:
			currentColour = "Cyan";
			sr.color = colorCyan;
			break;
		case 1:
			currentColour = "Red";
			sr.color = colorRed;
			break;
		case 2:
			currentColour = "Chocolate";
			sr.color = colorChocolate;
			break;
		case 3:
			currentColour = "Yellow";
			sr.color = colorYellow;
			break;
		}
	}

	void Exit(){
		if (Input.GetKey(KeyCode.Escape)) {
			//Debug.Log ("Quit game");
			Application.Quit();
		}
	}
}
