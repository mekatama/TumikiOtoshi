using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title_Controller : MonoBehaviour {

	void Update(){
		//backキー
		if (Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();	//アプリ終了
		}
	}

	//アプリ終了
	public void OnExit(){
		Application.Quit();	//アプリ終了
	}

	//スタートボタン用の制御関数
	public void OnStartButtonClicked(){
		SceneManager.LoadScene("main");	//シーンのロード
	}

	//遊び方ボタン用の制御関数
	public void OnHowToPlayButtonClicked(){
		SceneManager.LoadScene("HowToPlay");	//シーンのロード
	}

	//タイトルに戻るボタン用の制御関数
	public void OnReturnTitleButtonClicked(){
		SceneManager.LoadScene("Title");	//シーンのロード
	}

	//コレクション画面へ行くボタン用の制御関数
	public void OnCollectionButtonClicked(){
		SceneManager.LoadScene("Collection");	//シーンのロード
	}
}
