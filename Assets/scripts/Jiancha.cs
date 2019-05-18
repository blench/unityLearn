using UnityEngine;
using System.Collections;
using System;

public class Jiancha : MonoBehaviour
{
		//public int sd;
		public int xm;
	
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (gameObject.transform.position.y < 0) {
						xm = GameObject.Find ("Main Camera").GetComponent <Sheji> ().xmshu++;
						print ("xm" + xm);
						//sd = GameObject.Find ("Main Camera").GetComponent <Sheji> ().sdshu;
						//GameObject.Find ("wenzi").GetComponent<GUIText> ().text = "射弹数：" + sd + " 消灭数：" + xm;
						if (xm > 20) {
								GameObject.Find ("wenzi").GetComponent<GUIText> ().text = "恭喜过关！继续努力！坚持就是胜利！";
								GameObject.Find ("Main Camera").GetComponent<Sheji> ().enabled = false;
								GameObject.Find ("dimian").GetComponent<Restart> ().enabled = true;
						}
						Destroy (gameObject);
				}
		}
}
