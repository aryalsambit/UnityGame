using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject Instructions;
	public GameObject Options;
	public GameObject Credits;
	
	void Start () {
	
	}
	
	void Update () {
	
	}

	public void Play(){
		Application.LoadLevel (1);
	}
	public void ToggleInstructions(){
		
	}
	public void ToggleOptions(){
		
	}
	public void ToggleCredits(){
		
	}
	public void Exit(){
		Application.Quit ();
	}
}
