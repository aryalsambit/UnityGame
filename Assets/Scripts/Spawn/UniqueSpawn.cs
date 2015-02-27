using UnityEngine;
using System.Collections;

public class UniqueSpawn : Spawn {


	protected override bool Spawned( int index){

		return myTransform.GetChild(index).childCount==0? base.Spawned(index):false;
}
}