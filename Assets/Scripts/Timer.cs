using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	private float current;
	private float max;
	public void Set(float current,float max)
		{
		this.current=current;
		this.max=max;
		}
	
	// Update is called once per frame
	public bool IsReady () {
		if (current >= 0) 
		{
			current-=Time.deltaTime;
			return false;

		}
		else
		{
			current=max;
			return true;
		}
			
		}
	
	}

