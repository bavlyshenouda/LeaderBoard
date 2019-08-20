using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Collections;
using ArabicSupport;


public class tile : MonoBehaviour {

    public string animal;
    public string name;
    public string score;
    public string rank;
    public GameObject pic;
    public TextMesh txt;
    public TextMesh rankTxt;
	// Use this for initialization
	void Start () {
        Debug.Log(animal);
        Material picMat = (Material)Resources.Load(animal, typeof(Material)) as Material;
        Debug.Log(picMat);
        pic.GetComponent<Renderer>().material = picMat;
        txt.text = ArabicFixer.Fix(name + " : " + score);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, Time.deltaTime*0.5f ,0);
	}
}
