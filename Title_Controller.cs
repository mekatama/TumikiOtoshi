using UnityEngine;
using System.Collections;

public class Title_Controller : MonoBehaviour {
	//スタートボタン用の制御関数
	public void OnStartButtonClicked(){
		Application.LoadLevel("main");	//シーンのロード
	}

	//遊び方ボタン用の制御関数
	public void OnHowToPlayButtonClicked(){
		Application.LoadLevel("HowToPlay");	//シーンのロード
	}

	//タイトルに戻るボタン用の制御関数
	public void OnReturnTitleButtonClicked(){
		Application.LoadLevel("Title");	//シーンのロード
	}
}
