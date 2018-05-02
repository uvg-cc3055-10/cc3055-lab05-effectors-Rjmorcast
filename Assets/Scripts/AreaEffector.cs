using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    private float time;
    private bool activated = true;
    public GameObject area;
    public GameObject area2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        //Area 1
        if ((time > 5) && (time < 7))
        {
            area.SetActive(false);
        }
        else {
            area.SetActive(true);        
        }
        //Area 2
        if ((time > 12) && (time < 14))
        {
            area2.SetActive(false);
        }
        else
        {
            area2.SetActive(true);
        }

        if (time == 15) {
            time = 0;
        }
    }
}
