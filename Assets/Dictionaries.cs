using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    Dictionary<string, GameObject> itemDatabase = new Dictionary<string, GameObject>();
    public string item;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;



	// Use this for initialization
	void Start ()
    {
        itemDatabase.Add("Arrow", item1);
        itemDatabase.Add("seigeBallista", item2);
        itemDatabase.Add("metalGate", item3);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
