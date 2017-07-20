using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection5 : MonoBehaviour {
	public Sprite icon5;
	private bool open5;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open5 = TumikiPut.tumikiOpen5;
		if(open5){
			iconImage.sprite = icon5;
		}
	}
}
