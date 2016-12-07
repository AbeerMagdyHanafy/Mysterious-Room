using UnityEngine;
using System.Collections;

public class Intersection : MonoBehaviour {

    public GameObject hand , book , finger;
    

    // Use this for initialization
    void Start () {
        hand = GameObject.FindGameObjectWithTag("hand");
        book = GameObject.FindGameObjectWithTag("book");
        finger = GameObject.FindGameObjectWithTag("finger");

    }

    // Update is called once per frame
    void Update() {
        //Check distance between Hand and the other Object
        float dist = Vector3.Distance(finger.transform.position, book.transform.position);
        Vector3 dir = (finger.transform.position - book.transform.position).normalized;
        

        float x = book.GetComponent<Renderer>().bounds.size.x;
        float y = book.GetComponent<Renderer>().bounds.size.y;
        float z = book.GetComponent<Renderer>().bounds.size.z;

        //float x =book.GetComponent<Renderer>().transform.lossyScale.x;
        //float y = book.GetComponent<Renderer>().transform.localScale.y;
        //float z = book.GetComponent<Renderer>().transform.localScale.z;

        if ((dir.x < 2) || (dir.y < 2) || (dir.z < 2))
        {
            Debug.Log("<2  " + dist + " " + dir + "x= "+x + " y= " + y + " z= "+z +" [] ");


        }
        else if ((dir.x < 0.5) || (dir.y<0.5) ||(dir.z <0.5))
        {
            Debug.Log("<0.5  " + dist + " " + dir + "x= " +  x + " y= " + y + " z= " + z +  " TRUE ");
        }
        else
        {
            Debug.Log(">2  " + dist + " " + dir + "x= " + x + " y= " + y + " z= " + z);
        }

    }
}
