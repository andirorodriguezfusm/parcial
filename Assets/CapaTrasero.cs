using UnityEngine;
using System.Collections;

public class CapaTrasero : MonoBehaviour {

	// Use this for initialization
	public void Crearcapatrasero (Vector3 posicion, Vector3 rotacion, Vector3 escala) {
		GameObject cylinder; 
		cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder); 
		cylinder.name="CapaTRasero";
		cylinder.transform.localScale = escala;
		cylinder.transform.position = posicion;
		cylinder.transform.eulerAngles = rotacion;
		
		
	
	}

}
