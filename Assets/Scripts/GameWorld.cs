using UnityEngine;
using System.Collections;


public class GameWorld : MonoBehaviour {
	public GameObject block ;

	public int n ;
	public int G = 12 ;
	 int total = 0;
	int lockermax= 7;
	public string curWorld = "world1";
	// Use this for initialization
public void build (){
		 //GameObject[]c = GameObject.FindGameObjectsWithTag ("Block"); 
		// deletes blocks 
						for (int a = 0; a < 144; a++) {
				Transform t = transform.FindChild ("Ground(Clone)");
			if (t!=null){
			DestroyImmediate (t.gameObject);
			}			
			}
		//adds new blocks 
		for (int y = 0; y< G; y++){
			for (int x = 0; x < G;x++) {
				// assign a type 
				n = Random.Range(0,6);
				if (n == 1 && total >= lockermax){
					n = 0;
				}
				if (n == 1){
					total++;
				}
				GameObject a = (GameObject) Instantiate (block,this.transform.position + new Vector3 (x - 5.462098f ,y - 4.621729f ,0),Quaternion.identity);
				a.transform.parent = this.transform;
				a.GetComponent<changetype>().change(n);

			    }
				}
		total = 0;
		}
	// function already descripes it !
	public void DestroyWorld(){
		for (int a = 0; a < 144; a++) {
			Transform t = transform.FindChild ("Ground(Clone)");
			if (t!=null){
				DestroyImmediate (t.gameObject);
			}			
		}
		total = 0;
		}
	}

