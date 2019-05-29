using UnityEngine;
using System.Collections;

public class Menu01 : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnGUI ()
		{
				if (GUI.Button (new Rect (180, 100, 60, 30), "退 出")) {
						Application.Quit ();
				}
				if (GUI.Button (new Rect (280, 100, 60, 30), "开始游戏")) {
						Application.LoadLevel ("1");
				}
				
		}

}
