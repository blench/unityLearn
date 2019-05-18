using System.Collections;
using UnityEngine;

public class Sheji : MonoBehaviour
{
		public int speed = 5;
		public Transform newObject;
		public int sdshu = 0;
		public int xmshu = 0;
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				float h = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
				float v = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
				transform.Translate (h, 0, v);
				if (Input.GetButtonDown ("Fire1")) {
						Transform t = Instantiate (newObject, transform.position, transform.rotation) as Transform;
						Vector3 fwd = transform.TransformDirection (Vector3.forward);
						t.rigidbody.AddForce (fwd * 2800);
						sdshu++;
						GameObject.Find ("wenzi").GetComponent <GUIText> ().text = "射弹数：" + sdshu + " 消灭数：" + xmshu;
						
				}

				if (Input.GetKey (KeyCode.Q)) {
						transform.Rotate (0, -25 * Time.deltaTime, 0, Space.Self);
				}
				if (Input.GetKey (KeyCode.E)) {
						transform.Rotate (0, 25 * Time.deltaTime, 0, Space.Self);
				}

				if (Input.GetKey (KeyCode.Z)) {
						transform.Rotate (-25 * Time.deltaTime, 0, 0, Space.Self);
				}
				if (Input.GetKey (KeyCode.C)) {
						transform.Rotate (25 * Time.deltaTime, 0, 0, Space.Self);
				}

				if (Input.GetKey (KeyCode.H)) {
						transform.Translate (0, 5 * Time.deltaTime, 0);
				}
				if (Input.GetKey (KeyCode.N)) {
						transform.Translate (0, -5 * Time.deltaTime, 0);
				}
								
		}
}
