using UnityEngine;
using System.Collections;

public class Player_Controls : MonoBehaviour {
	public float speed = 1f;
	public GameObject Block;
	public Vector3 pos ;
	void Update () {
		// WASD & Arrow Keys -Movement
		this.transform.position += new Vector3 (Input.GetAxis("Horizontal")* speed   /*down*/ , Input.GetAxis("Vertical")*speed  /*up*/ , 0);
	
	
		//Mining
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

			if(hit.collider != null){
				GameObject target =(GameObject)hit.collider.gameObject;
				//enemy attack
				if (target.name == "Enemy"){
					battle b =target.GetComponent<battle>();
					if(b!= null){
						b.StartCoroutine("animate");
					}
					if (b == null){
						Debug.Log ("Missing script!");
					}
				}
				else{
				// portals
				Animator anim = target.GetComponent<Animator>();
				if( anim != null){
				anim.SetTrigger("Chopping");
				                  }
					pos = target.transform.position;
				Destroy(target);
				GameObject a =(GameObject) Instantiate(Block , pos, Quaternion.identity);

					a.GetComponent<changetype>().change(6);
				}
				}
			}
			}
	
		}





