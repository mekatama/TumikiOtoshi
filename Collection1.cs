using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collection1 : MonoBehaviour {
	public Sprite icon1;
	private bool open1;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open1 = TumikiPut.tumikiOpen1;
		if(open1){
			iconImage.sprite = icon1;
		}
	}
}
