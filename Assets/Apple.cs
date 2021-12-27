using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
	public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy (this.gameObject);

			// Получить ссылку на компонент ApplePicker главной камеры Main Camera
			Apple_Picker apScript = Camera.main.GetComponent<Apple_Picker>();// b
			// Вызвать общедоступный метод AppleDestroyed() из apScript
			apScript.AppleDestroyed();
		}
	}
}
