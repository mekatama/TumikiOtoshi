using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collection3 : MonoBehaviour {
	public Sprite icon3;
	private bool open3;
	Image iconImage;	//検索したオブジェクト入れる用ジェクト入れる用

	void Start () {
		iconImage = GetComponent<Image>();
		open3 = TumikiPut.tumikiOpen3;
		if(open3){
			iconImage.sprite = icon3;
		}
	}
}
