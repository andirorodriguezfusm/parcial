using UnityEngine;
using System.Collections;

public class Ventanas : MonoBehaviour {

	public void  Crearventanas (Vector3 posicion, Vector3 rotacion, Vector3 escala) {
		
		GameObject Sphere;
		Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
		Sphere.name="ventanas";
		Sphere.transform.localScale = escala;
		Sphere.transform.position = posicion;
		Sphere.transform.eulerAngles = rotacion;
		
		
	}

}
