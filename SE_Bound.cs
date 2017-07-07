using UnityEngine;
using System.Collections;

public class SE_Bound : MonoBehaviour {
	AudioSource boundSound;			//AudioSourceコンポーネント取得用

	void Start () {
		boundSound = GetComponent<AudioSource>();
	}
	
	//他のオブジェクトとの当たり判定
	void OnCollisionEnter2D(Collision2D other) {
//		if(other.tag == "Tumiki"){
			boundSound.Play();	//SE再生
			Debug.Log("SE再生");
//		}
	}
}
