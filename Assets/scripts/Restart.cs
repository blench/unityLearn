using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				OnGUI ();
		}

		void OnGUI ()
		{
				if (GUI.Button (new Rect (180, 100, 60, 30), "退 出")) {
						Application.Quit ();
				}
				if (GUI.Button (new Rect (280, 100, 60, 30), "重新开始")) {
						Application.LoadLevel ("1");
				}
				if (GUI.Button (new Rect (10, 160, 60, 50), "Play")) {
						audio.Pause ();
				}
				if (GUI.Button (new Rect (10, 220, 100, 50), "Stop")) {
						audio.Stop ();
				}
		}

}
