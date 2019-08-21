using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class Main : MonoBehaviour {

    //public Text txt;
    public GameObject titlePrefab;
    private int rank;
    // Use this for initialization
	void Start () {
        rank = 1;
        loadDate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void loadDate() {
        //Debug.Log("Start Fetch");
        StreamReader strReader = new StreamReader("C:\\Users\\pc\\Desktop\\score.csv", Encoding.UTF8);
        bool endFile = false;
        while (!endFile) { 
            string data_string = strReader.ReadLine();
            if (data_string == null) {
                endFile = true;
                break;
            }
            var data_values = data_string.Split(',');
            //txt.text = ArabicFixer.Fix(data_values[0].ToString());
            //Debug.Log(data_values[0].ToString() + " : " +data_values[1].ToString());
            titlePrefab.GetComponent<tile>().animal = data_values[0].ToString();
            titlePrefab.GetComponent<tile>().name = data_values[1].ToString();
            titlePrefab.GetComponent<tile>().score = data_values[2].ToString();
            titlePrefab.GetComponent<tile>().rank = rank.ToString();
            float yLoc = (float)(-4 - ((rank - 1) * 0.9));
            Vector3 loc = new Vector3(0, yLoc, 0);
            Instantiate(titlePrefab, loc, Quaternion.identity);
            rank = rank +1;

        }
    }
}
