using UnityEngine;
using System.Collections;

public class tren : MonoBehaviour {

	public void creartren(){
		Capa crr = new Capa ();
		Llantas rue = new Llantas ();
		Ventanas spo = new Ventanas();
		CapaTrasero rui = new CapaTrasero ();


		crr.crearcapa(new Vector3(0.5630741f, 0.5403566f, 0f), new Vector3(0f, 0f, 0f), new Vector3(3.217848f, 0.271692f, 1.389654f));
		crr.crearcapa(new Vector3(-1.533485f, 1.200633f, -0.003550291f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1.598438f, 1.350781f));
		crr.crearcapa(new Vector3(-1.577574f, 2.073261f, -0.5873773f), new Vector3(-20.51868f, -2.405319f, -0.9354858f), new Vector3(1f, 0.1313882f, 1.38093f));
		crr.crearcapa(new Vector3(-1.542938f, 2.106706f, 0.6440997f), new Vector3(18.80577f, 0.1315918f, -2.354919f), new Vector3(1f, 0.15f, 1.380931f));
		
		rue.Crearllanta(new Vector3(1.107967f, 0.4584278f, -0.7744012f), new Vector3(87.12791f, 62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		rue.Crearllanta(new Vector3(-0.1750989f, 0.4026016f,-0.7302859f), new Vector3(87.12791f,62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		rue.Crearllanta(new Vector3(-1.558668f,0.5291241f,-0.7984353f), new Vector3(87.12791f, 62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		rue.Crearllanta(new Vector3(1.235027f,0.5017045f,0.8264855f), new Vector3(87.12791f,62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		rue.Crearllanta(new Vector3(-0.2174479f,0.4365387f,0.7927128f), new Vector3(87.12791f,62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		rue.Crearllanta(new Vector3(-1.503767f,0.379555f,0.7937315f), new Vector3(87.12791f,62.04955f, 57.47896f), new Vector3(1f,0.1250002f,1f));
		
		rui.Crearcapatrasero(new Vector3(0.5307451f, 1.177119f, 0f), new Vector3(0f, 0f, 89.36583f), new Vector3(1f, 1.512054f, 1f));
		rui.Crearcapatrasero(new Vector3(1.61291f, 1.908012f, -0.06199484f), new Vector3(0f, 0f, 0f), new Vector3(0.2985324f, 0.3007353f, 0.2848491f));
		rui.Crearcapatrasero(new Vector3(0.6267116f, 1.857866f, -0.06199484f), new Vector3(0f, 0f, 0f), new Vector3(0.2985324f, 0.2255515f, 0.2848491f));
		rui.Crearcapatrasero(new Vector3(-0.3093403f, 1.791005f, -0.06199484f), new Vector3(0f, 0f, 0f), new Vector3(0.2985324f, 0.1804412f, 0.2848491f));
		rui.Crearcapatrasero(new Vector3(1.954822f, 0.5515702f, -0.8196614f), new Vector3(0f, 0f, -89.10629f), new Vector3(0.3691543f, 0.2181793f, 0.3750002f));
		rui.Crearcapatrasero(new Vector3(1.954822f, 0.5515702f, 0.7550583f), new Vector3(0f, 0f, -89.10632f), new Vector3(0.3691543f, 0.2181793f, 0.3750002f));
		rui.Crearcapatrasero(new Vector3(2.411187f, 0.5584855f, 0.3939016f), new Vector3(0f, 0f, -89.10629f), new Vector3(0.2246797f, 0.03863865f, 0.2601552f));
		rui.Crearcapatrasero(new Vector3(2.411187f, 0.5584855f, -0.4120142f), new Vector3(0f, 0f, -89.10629f), new Vector3(0.2246797f, 0.03863865f, 0.2601552f));
		rui.Crearcapatrasero(new Vector3(2.272105f, 0.5565196f, -0.4064974f), new Vector3(0f, 0f, -89.10629f), new Vector3(0.1680485f, 0.1108031f, 0.1930651f));
		rui.Crearcapatrasero(new Vector3(2.272105f, 0.5565196f, -0.3939016f), new Vector3(0f, 0f, -89.10629f), new Vector3(0.1680485f, 0.1108031f, 0.1930651f));
		
		
		
		spo.Crearventanas(new Vector3(-1.594057f, 1.511167f, -0.6628206f), new Vector3(0f, 0f, 0f), new Vector3(1f, 0.7375f, -0.1253996f));
		spo.Crearventanas(new Vector3(-1.594057f, 1.511167f, 0.6550858f), new Vector3(0f, 0f, 0f), new Vector3(1f, 0.7375f, -0.1253996f));
		
	}
	
}
