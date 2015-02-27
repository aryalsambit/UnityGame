using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {
	public float Speed=5;
	public Health Health;
	public Stamina Stamina;
	public Weapon Weapon;

	// Use this for initialization
	public virtual void Start () {
		Stamina.OnSprint+= () => Speed=10;
		Stamina.OnWalk+= () => Speed=5;
		Health.OnDeath += () => Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}
}
