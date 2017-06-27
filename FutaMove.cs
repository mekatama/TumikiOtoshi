using UnityEngine;
using System.Collections;

public class FutaMove : MonoBehaviour {
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		TumikiPut gc = gameController.GetComponent<TumikiPut>();
		//蓋の開閉フラグを見る
		if(gc.tumikiNagasu == true){
			transform.position = new Vector2(-5.5f,-2.5f);	//強引にオブシェクトを動かす
		}else{
			transform.position = new Vector2(0.0f,-2.5f);	//強引にオブシェクトを動かす
		}
	}
}
