using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection6 : MonoBehaviour {
	public Sprite icon6;
	private bool open6;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open6 = TumikiPut.tumikiOpen6;
		if(open6){
			iconImage.sprite = icon6;
		}
	}
}
