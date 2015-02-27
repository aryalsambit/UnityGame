using UnityEngine;
using System.Collections;

public class Ranged : Weapon {

	public int Ammo =0;
	private Timer timer;
	public Ranged range;
	protected override void Start () {
		
		 timer =new Timer();

		timer.Set (0, reloadTime);
			
	}

	void Update () {
		
	}
	public override void Attack(){
		RaycastHit hit;
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, range)) {
			hit.transform.GetComponent<Actor>().Health.Current -= Damage;
		}
		
	}
}


