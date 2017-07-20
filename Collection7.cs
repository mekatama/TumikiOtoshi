using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection7 : MonoBehaviour {
	public Sprite icon7;
	private bool open7;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open7 = TumikiPut.tumikiOpen7;
		if(open7){
			iconImage.sprite = icon7;
		}
	}
}
