using UnityEngine;
using System.Collections;

public class TumikiDelete : MonoBehaviour {
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start(){
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Tumiki"){
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			TumikiPut gc = gameController.GetComponent<TumikiPut>();
			//このGameObjectを［Hierrchy］ビューから削除する
			Destroy(other.gameObject);
			//積木生成数を減らす→0になったら再度生成できようにしたい
			gc.tumikiNum -= 1;
//			Debug.Log("積木の数=" + gc.tumikiNum);
		}
	}
}
