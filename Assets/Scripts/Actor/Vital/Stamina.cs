using UnityEngine;
using System;

public class Stamina : Vital {
	private bool isSprint = false;
	public bool IsUsing = false;
	public event Action OnSprint;
	public event Action OnWalk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {

		if ( IsUsing&& Current > 0) {
			if(!isSprint)
			{
				OnSprint();
			isSprint=true;
			}
			Current -= Time.deltaTime;
				} 
		else if(isSprint)
			{
				OnWalk();
				isSprint=false;
		    }
	}
}
