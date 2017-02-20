using UnityEngine;
using System.Collections;

public class HealthUpGrade : MonoBehaviour {
	public AudioSource Aud ;

public void OnTriggerEnter2D(Collider2D other){
		Player p = (Player)other.GetComponent<Player> ();
		p.Healthpotion (10);
		Debug.Log ("+10 <3");
		Aud.Play ();
		Destroy (this.gameObject);
	
	}

}
