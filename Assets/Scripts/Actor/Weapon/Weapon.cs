using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {
	public float Damage;
	public float reloadTime;
	private Timer timer;

		protected override void Start () {
			
			timer =new Timer();
			
			timer.Set (0, reloadTime);
	
	}
	

	void Update () {

	if (Input.GetMouseButton (0)&& timer.IsReady) 
	{
	 // Attack
	}

	}

	public virtual void Attack(){

		}
}
