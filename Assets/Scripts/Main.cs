using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	//private TextAsset data =  
    // Use this for initialization
	void Start () {
        loadDate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadDate() {

        Debug.Log("Start Fetch"); 
        System.IO.StreamReader strReader = new System.IO.StreamReader("C:\\Users\\pc\\Desktop\\scores.csv");
        bool endFile = false;
        while (!endFile) { 
            string data_string = strReader.ReadLine();
            if (data_string == null) {
                endFile = true;
                break;
            }
            var data_values = data_string.Split(',');
            Debug.Log(data_values[0].ToString()+ " : " +data_values[1].ToString()); 
        }
    }
}
