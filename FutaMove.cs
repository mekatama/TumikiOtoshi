using UnityEngine;
using System.Collections;

public class FutaMove : MonoBehaviour {
	GameObject gameController;			//検索したオブジェクト入れる用
	AudioSource audioSource;			//AudioSourceコンポーネント取得用
	public AudioClip audioClipOpen;		//開くSE
	public AudioClip audioClipClose;	//閉じるSE

	private int seGo = 1;				//SEなり分けようフラグ

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
		audioSource = gameObject.GetComponent<AudioSource>();		//AudioSourceコンポーネント取得
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		TumikiPut gc = gameController.GetComponent<TumikiPut>();
		//蓋の開閉フラグを見る
		if(gc.tumikiNagasu == true){
			//OPEN
			transform.position = new Vector2(-5.5f,-1.1f);	//強引にオブシェクトを動かす
			if(seGo == 1){
				audioSource.clip = audioClipClose;				//SE決定
				audioSource.Play ();							//SE再生
				seGo = 0;
			}
		}else{
			//CLOSE
			transform.position = new Vector2(0.0f,-1.1f);	//強引にオブシェクトを動かす
			if(seGo == 0){
				audioSource.clip = audioClipOpen;				//SE決定
				audioSource.Play ();							//SE再生
				seGo = 1;
			}
		}
	}
}
