using UnityEngine;
using System.Collections;

public class FlyCam2: MonoBehaviour {

	//скорость управления камеры
	public float speed = 50.0f;


	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	}

	// Update is called once per frame
	void Update () {

		Cursor.visible = true;


		//Управление камерой
		Vector3 dir = new Vector3 ();

		if (Input.GetKey(KeyCode.W)) dir.z += 1.0f;
		if (Input.GetKey(KeyCode.S)) dir.z -= 1.0f;
		if (Input.GetKey(KeyCode.A)) dir.x -= 1.0f;
		if (Input.GetKey(KeyCode.D)) dir.x += 1.0f;
		if (Input.GetKey(KeyCode.O)) dir.y -= 1.0f;
		if (Input.GetKey(KeyCode.P)) dir.y += 1.0f;


		dir.Normalize ();

			transform.Translate ( dir * speed * Time.deltaTime );
	}

}
