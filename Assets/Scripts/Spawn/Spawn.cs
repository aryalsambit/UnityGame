using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject[] resources;
	protected Transform myTransform;
	private Timer timer;
	void Start () {
		myTransform = transform;
		timer.Set( Random.Range (0, 2), 3);

	}
	

	void Update () {
				if (timer.IsReady) {
						int index = Random.Range (0, myTransform.childCount);
						while (!Spawned(index)&&counter<resources.Length)
								index = index % resources.Length;
						counter++;

				}
		}
	protected virtual bool Spawned(int index){

		Transform child=myTransform.GetChild(index);
		GameObject resource = (GameObject)GameObject.Instantiate(resources[Random.Range(0,resources.Length)]);
		resource.transform.parent = child;
		resource.transform.position = child.position;
		return true;
		}
}
