using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour
{

    public GameObject book, hand , finger;


    // Use this for initialization
    void Start()
    {
        book = GameObject.FindGameObjectWithTag("book");
        hand = GameObject.FindGameObjectWithTag("hand");
        finger = GameObject.FindGameObjectWithTag("finger");
        // IsCollied();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(finger.transform.position, book.transform.position);
        Vector3 temp = Input.mousePosition;
        
        if ((dist >= -1.5f) && (dist <= 1.5f))
        {
            Debug.Log("no" + dist);
           // temp.z = 1f;
            //this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }
        else
        {
            Debug.Log("yes" + dist);
            temp.z = 10f;// Set this to be the distance you want the object to be placed in front of the camera.    
            this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }

    }


    int isColliededVal;

    public bool IsCollied()
    {
        var heading = this.transform.position - book.transform.position;
        Vector3 zeroVector = new Vector3(0.0f, 0.0f, 0.0f);
        bool isCollieded;
        if (heading == zeroVector)
        {
            isCollieded = true;
            Debug.Log("stop");
        }
        else
        {
            isCollieded = false;
            Debug.Log(isCollieded);
        }
        return isCollieded;

    }
}
