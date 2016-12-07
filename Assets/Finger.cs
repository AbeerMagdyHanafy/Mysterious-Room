using UnityEngine;
using System.Collections;

public class Finger : MonoBehaviour {

    public GameObject hand;
    int  countUp=0, countDown=0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            if ((countDown <= 2) && (countDown >= 0) )
            {
                position.y += 0.1f;
                countDown++;
                //this.transform.position = position;
                if ((countUp != 0))
                { countUp--; }
                this.transform.position = position;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;

            if ((countUp <= 2) && (countUp >= 0) )
            {
                position.y -= 0.1f;
               
                countUp++;
               // this.transform.position = position;
                if ((countDown != 0))
                { countDown--; }
                this.transform.position = position;
            }
           
        }
    }
}
