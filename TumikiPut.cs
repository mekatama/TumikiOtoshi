using UnityEngine;
using System.Collections;

public class TumikiPut : MonoBehaviour {
	public GameObject tumiki_01;	//タップして出現させたいプレハブ
	public GameObject tumiki_02;	//タップして出現させたいプレハブ
	public GameObject tumiki_03;	//タップして出現させたいプレハブ
	public int tumikiNum = 0;		//生成したプレハブの数を保存(フタ開閉用)
	public int tumikiNumAll = 0;	//生成したプレハブの数を保存(総数)
	public bool tumikiNagasu = false;	//
	AudioSource tapSound;			//AudioSourceコンポーネント取得用
	ParticleSystem tapEffect;		//

	public static bool tumikiOpen1 = false;
	public static bool tumikiOpen2 = false;
	public static bool tumikiOpen3 = false;

	void Start () {
		tapSound = GetComponent<AudioSource>();
		tapEffect = GetComponent<ParticleSystem>();
	}

	void Update () {
		GameObject obj = getClickObject();	//

		//タップした場所の座標を取得→プレハブ生成
		if(Input.GetMouseButtonDown(0)){
			Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);	//スクリーン座標

			if(obj.tag == "Wall"){
				Debug.Log("click=" + obj.tag);
			}else if(obj.tag == "Futa"){
				Debug.Log("click=" + obj.tag);
			}else{
	//			Debug.Log("x=" + vec.x + "y=" + vec.y);
				Debug.Log("click=" + obj.tag);

				tapEffect.transform.position = vec;
				tapEffect.Emit(1);

				int ran = Random.Range(0,3);											//ランダム
				switch(ran){
					case 0:
						Instantiate(tumiki_01,vec,tumiki_01.transform.rotation);			//プレハフ生成
						tumikiOpen1 = true;
						tapSound.Play();	//SE再生
						break;
					case 1:
						Instantiate(tumiki_02,vec,tumiki_02.transform.rotation);			//プレハフ生成
						tumikiOpen2 = true;
						tapSound.Play();	//SE再生
						break;
					case 2:
						Instantiate(tumiki_03,vec,tumiki_03.transform.rotation);			//プレハフ生成
						tumikiOpen3 = true;
						tapSound.Play();	//SE再生
						break;
				}
				tumikiNum += 1;
				tumikiNumAll += 1;
				Debug.Log("積木の数=" + tumikiNum);
				Debug.Log("積木の総数=" + tumikiNumAll);
			}
		}

		//積木生成数でフラグのon/off
		if(tumikiNum > 30 && tumikiNagasu == false){
			tumikiNagasu = true;
		}
		if(tumikiNum == 0 && tumikiNagasu == true){
			tumikiNagasu = false;
		}
//			Debug.Log("Nagasu=" + tumikiNagasu);
	}


	//タップしたオブジェクト取得関数
	private GameObject getClickObject(){
		GameObject result = null;
		if(Input.GetMouseButtonDown(0)){
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);	//スクリーン座標
			Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
			if(collition2d){
				result = collition2d.transform.gameObject;
			}
		}
		return result;
	}

}
