using UnityEngine;
using System.Collections;
using System;

public class Health : Vital {
	public event Action OnDeath;
	public override float Current {

		set
		{
			base.Current = value;
			if(Current==0)
			{
				OnDeath();
			}
		}

	}
}
