using UnityEngine;
using System.Collections;

public class SE_Bound : MonoBehaviour {
	AudioSource boundSound;			//AudioSourceコンポーネント取得用

	void Start () {
		boundSound = GetComponent<AudioSource>();	//AudioSourceコンポーネント取得
	}
	
	//他のオブジェクトとの当たり判定
	void OnCollisionEnter2D(Collision2D other) {
		boundSound.Play();	//SE再生
		//ちょっとだけ拡大させる
		transform.localScale = new Vector2(1.4f, 1.4f);
		//0.1秒後に呼び出す
    	Invoke("ScaleReset", 0.07f);
	}

	//時間差ですけーるを戻したい用
	void ScaleReset(){
		//元のスケールに戻す
		transform.localScale = new Vector2(1.28f, 1.28f);
	}
}
