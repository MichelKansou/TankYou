using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject ResumeMenu;

	// Use this for initialization
	void Start () {
		ResumeMenu.gameObject.SetActive(false);
	}

	public void ResumeGame(){
		ResumeMenu.gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		if (ResumeMenu.activeSelf == false && Input.GetKeyDown (KeyCode.Escape)) {
			ResumeMenu.gameObject.SetActive (true);
		} else if (ResumeMenu.activeSelf == true && Input.GetKeyDown (KeyCode.Escape)) {
			ResumeMenu.gameObject.SetActive (false);
		}
	}
}
