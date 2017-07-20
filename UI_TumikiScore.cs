using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TumikiScore : MonoBehaviour {
	public Text scoreLabel;
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		TumikiPut gc = gameController.GetComponent<TumikiPut>();
		scoreLabel.text = gc.tumikiNumAll.ToString("000000");
	}
}
