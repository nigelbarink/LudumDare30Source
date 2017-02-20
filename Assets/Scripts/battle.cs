using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class battle : MonoBehaviour {
	public int Lives = 10;
	public Player p;
	public Text LiveCounter;
	public AudioSource aud;

public void Update (){
		LiveCounter.text = "Lives: " + Lives.ToString()+ "/10";
	}
public IEnumerator animate(){
				p = GameObject.Find ("Player").GetComponent<Player> ();
		p.GetComponent<Player_Controls> ().enabled = false;

				while (p.lives >= 0.1f && Lives >=0) {
			if (Lives <= 0) {
				die ();
				p.GetComponent<Player_Controls>().enabled = true;
			}
						//player attacks
						int Damage = 1;
						TakeDamage (Damage);
						aud.Play();
						Debug.Log ("You did " + Damage + " Damage!");
					
	
						yield return new WaitForSeconds (1f);
						// enemy Attacks 
						float hit = 1;
						p.TakeDamage (hit);
						aud.Play();
						Debug.Log ("you toke " + hit + " Damage!");

						yield return new WaitForSeconds (1f);

			yield return new WaitForSeconds (0.25f);
				}
			
		}
	public void TakeDamage(int Damage){
		Lives -= Damage;
	}

public void die (){
		p.killed ++;
		Destroy (this.gameObject);
	}


	}

