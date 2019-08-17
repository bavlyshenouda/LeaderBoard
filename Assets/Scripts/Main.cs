using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArabicSupport;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class Main : MonoBehaviour {

    public Text txt;

    // Use this for initialization
	void Start () {
        loadDate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadDate() {

        Debug.Log("Start Fetch");
        StreamReader strReader = new StreamReader("C:\\Users\\pc\\Desktop\\score.csv", Encoding.UTF8);
        bool endFile = false;
        while (!endFile) { 
            string data_string = strReader.ReadLine();
            if (data_string == null) {
                endFile = true;
                break;
            }
            var data_values = data_string.Split(',');
            txt.text = ArabicFixer.Fix(data_values[0].ToString());
            Debug.Log(data_values[0].ToString() + " : " +data_values[1].ToString()); 
        }
    }
}
