using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection4 : MonoBehaviour {
	public Sprite icon4;
	private bool open4;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open4 = TumikiPut.tumikiOpen4;
		if(open4){
			iconImage.sprite = icon4;
		}
	}
}
