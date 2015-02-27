using UnityEngine;
using System.Collections;

public class Player : Actor {

	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {
		Stamina.IsUsing=Input.GetKey (KeyCode.LeftShift);
	}
}
