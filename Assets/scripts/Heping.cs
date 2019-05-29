using UnityEngine;
using System.Collections;

public class Heping : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnCollisionEnter ()
		{
				GameObject.Find ("wenzi").GetComponent<GUIText> ().text = "如果失去了和平，世界将会怎样";
				//GameObject.Find ("pxg").GetComponent<Light> () .enabled = false;
				//GameObject.Find ("Point light").GetComponent<Light> ().enabled = false;
				//GameObject.Find ("Point light1").GetComponent<Light> ().enabled = false;
				GameObject.Find ("Spotlight").GetComponent<Light> ().enabled = false;
				//destroy gameObject
				Destroy (gameObject);
		}
}
