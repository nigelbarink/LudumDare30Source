using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider2D),typeof(AudioSource))]
public class Portal : MonoBehaviour {
	 public GameObject[] EndP = new GameObject[5]  ;
	public AudioClip Clip;
	AudioSource Aud ;

	void Start(){
		BoxCollider2D b2 = (BoxCollider2D)this.GetComponent<BoxCollider2D> ();
		b2.isTrigger = true;
		Clip = (AudioClip)Resources.Load<AudioClip> ("SFX/Portal");
		if (Clip == null) {
			Debug.Log (	"Fail ");	
		}
		 Aud = (AudioSource)this.GetComponent<AudioSource> ();
		Aud.clip = Clip;
		Aud.playOnAwake = false;
	}

	public void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("pfff");
		EndP = GameObject.FindGameObjectsWithTag ("portal");
		other.transform.position = EndP [Random.Range (0,5)].transform.position;

		Aud.Play ();
	}
}
