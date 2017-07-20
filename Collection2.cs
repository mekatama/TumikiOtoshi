using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collection2 : MonoBehaviour {
	public Sprite icon2;
	private bool open2;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open2 = TumikiPut.tumikiOpen2;
		if(open2){
			iconImage.sprite = icon2;
		}
	}
}
