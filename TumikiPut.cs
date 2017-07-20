using UnityEngine;
using System.Collections;

public class TumikiPut : MonoBehaviour {
	public GameObject tumiki_01;	//タップして出現させたいプレハブ
	public GameObject tumiki_02;	//タップして出現させたいプレハブ
	public GameObject tumiki_03;	//タップして出現させたいプレハブ
	public GameObject tumiki_04;	//タップして出現させたいプレハブ
	public GameObject tumiki_05;	//タップして出現させたいプレハブ
	public GameObject tumiki_06;	//タップして出現させたいプレハブ
	public GameObject tumiki_07;	//タップして出現させたいプレハブ
	public GameObject tumiki_08;	//タップして出現させたいプレハブ
	public int tumikiNum = 0;		//生成したプレハブの数を保存(フタ開閉用)
	public int tumikiNumAll = 0;	//生成したプレハブの数を保存(総数)
	public bool tumikiNagasu = false;	//つむきを流すかどうかのフラグ
	AudioSource tapSound;			//AudioSourceコンポーネント取得用
	ParticleSystem tapEffect;		//タップ時Effect用

	public static bool tumikiOpen1 = false;	//コレクション画面用のフラク
	public static bool tumikiOpen2 = false;
	public static bool tumikiOpen3 = false;
	public static bool tumikiOpen4 = false;
	public static bool tumikiOpen5 = false;
	public static bool tumikiOpen6 = false;
	public static bool tumikiOpen7 = false;
	public static bool tumikiOpen8 = false;

	void Start () {
		tapSound = GetComponent<AudioSource>();		//SE用コンポーネント取得用
		tapEffect = GetComponent<ParticleSystem>();	//EFFECT用コンポーネント取得用
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

				int ran = Random.Range(0,200);											//ランダム
				if(ran >= 0 && ran < 61){
					Instantiate(tumiki_01,vec,tumiki_01.transform.rotation);			//プレハフ生成
					tumikiOpen1 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 61 && ran < 111){
					Instantiate(tumiki_02,vec,tumiki_02.transform.rotation);			//プレハフ生成
					tumikiOpen2 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 111 && ran < 151){
					Instantiate(tumiki_03,vec,tumiki_03.transform.rotation);			//プレハフ生成
					tumikiOpen3 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 151 && ran < 188){
					Instantiate(tumiki_04,vec,tumiki_04.transform.rotation);			//プレハフ生成
					tumikiOpen4 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 188 && ran < 194){
					Instantiate(tumiki_05,vec,tumiki_05.transform.rotation);			//プレハフ生成
					tumikiOpen5 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 194 && ran < 97){
					Instantiate(tumiki_06,vec,tumiki_06.transform.rotation);			//プレハフ生成
					tumikiOpen6 = true;
					tapSound.Play();	//SE再生
				}else if(ran >= 97 && ran < 199){
					Instantiate(tumiki_07,vec,tumiki_07.transform.rotation);			//プレハフ生成
					tumikiOpen7 = true;
					tapSound.Play();	//SE再生
				}else if(ran == 199){
					Instantiate(tumiki_08,vec,tumiki_08.transform.rotation);			//プレハフ生成
					tumikiOpen8 = true;
					tapSound.Play();	//SE再生
				}
				tumikiNum += 1;
				tumikiNumAll += 1;
				Debug.Log("積木の数=" + tumikiNum);
				Debug.Log("積木の総数=" + tumikiNumAll);
			}
		}

		//積木生成数でフラグのon/off
		if(tumikiNum == 30 && tumikiNagasu == false){
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
