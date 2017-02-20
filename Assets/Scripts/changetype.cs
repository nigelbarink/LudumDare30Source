using UnityEngine;
using System.Collections;

public class changetype : MonoBehaviour {
	public Sprite[] b = new Sprite[6] ;
	public RuntimeAnimatorController animations;
public void change(int num ){
			SpriteRenderer sr = (SpriteRenderer) this.GetComponent<SpriteRenderer>();
			sr.sprite = b[num];
		if (sr.sprite == b [1] ) {
						Animator anim = this.gameObject.AddComponent<Animator> ();
						anim.runtimeAnimatorController = animations;
						this.gameObject.AddComponent<BoxCollider2D> ();

	}
		if (num == 6) {
		 this.gameObject.AddComponent<Portal>();	
		}
}
}