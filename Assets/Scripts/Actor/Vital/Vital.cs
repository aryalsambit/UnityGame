using UnityEngine;
using System.Collections;

public abstract class Vital : MonoBehaviour {
	private float current;
	private float max;

	public  virtual float Current
	{ 
		get
		{
			return current;
		}
		set
		{
			current=Mathf.Clamp(value,0,max);
		}
	}
	public float Max;
	public virtual void Start () {
		current=max=5;
	}

	// Update is called once per frame
	public virtual void Update () {
	
	}
}
