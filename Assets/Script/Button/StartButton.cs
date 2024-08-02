using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartButton : MonoBehaviour{

	public string Level;
	public GameObject Button;
	private Color myColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void StartGame(){
		Debug.Log ("Start Level");
		SceneManager.LoadScene (Level);
	}

	public void GameOver(){
		Debug.Log ("Game Over");
		Application.Quit();
	}

	public void PointerEnter(){
		Button.GetComponent<Image> ().color = Color.blue;
	}

	public void PointerExit(){
		myColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		Button.GetComponent<Image> ().color = myColor;
	}
}
