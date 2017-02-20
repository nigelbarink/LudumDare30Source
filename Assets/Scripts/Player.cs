using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
	public int killed = 0;
	public float lives = 50f; 
	public int num = 0;
	// ------------------------------------
	public Image tip ;
	public Canvas GameOver;
	public Sprite[] tips ;
	public Text liveCounter ;
public void Start(){
		tip.sprite = tips [0];

	}

public void TakeDamage(float damage){
		lives -= damage;
	}
	public void Healthpotion(float ExtraLives ){
		lives += ExtraLives;
	}
	public void Update (){
	if (lives <= 0f) {
			ShowLosed();		
		}
		ShowLives ();

	}
	public void ShowLosed(){
		GameOver.enabled = true;
		this.GetComponent<Player_Controls>().enabled = false;
		return;
	}

	public void ShowIntro (){
		if (num == 2) {
			tip.canvas.enabled = false;
			this.GetComponent<Player_Controls>().enabled = true;
			return;
		}

		tip.sprite = tips [num+1];
		num++;
	}

	public void ShowLives(){
		liveCounter.text = "Lives: " + lives.ToString ()+ "/160";
	}
public void ReloadGame(){
		Application.LoadLevel ("0");
	}
}


