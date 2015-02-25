using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	public int min = 1;
	public int max = 1000;
	
	public Text guessText;
	
	int currentlyGuessing;
	void Start(){
		StartGame();
	}
	void StartGame(){
		NextGuessing();
		max += 1;
	}
	
	public void GuessHigher(){
		this.min = this.currentlyGuessing;
		NextGuessing();
	}
	
	public void GuessLower(){
		this.max = this.currentlyGuessing;
		NextGuessing();
	}
	
	void NextGuessing(){
		currentlyGuessing = Random.Range (min,max);
		guessText.text = currentlyGuessing.ToString();
	}
	
}
