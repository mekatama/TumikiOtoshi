using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection8 : MonoBehaviour {
	public Sprite icon8;
	private bool open8;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open8 = TumikiPut.tumikiOpen8;
		if(open8){
			iconImage.sprite = icon8;
		}
	}
}
