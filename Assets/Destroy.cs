using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    GameObject mainCamObj;

    // Use this for initialization
    void Start () {

        //メインカメラの取得
        mainCamObj = Camera.main.gameObject;

    }
	
	// Update is called once per frame
	void Update () {

        //画面外に出たらオブジェクトを破棄する
        if(transform.position.z< mainCamObj.transform.position.z){

            Destroy(gameObject);

        }
		
	}

  
}
