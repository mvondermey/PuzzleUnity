using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    //
    public GameObject slot;
    float xtemp;
    float ytemp;
    //
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp ()
    {


            xtemp = transform.localPosition.x;
            ytemp = transform.localPosition.y;
            transform.localPosition = new Vector3(slot.transform.position.x, slot.transform.position.y, 0);
            slot.transform.position = new Vector3(xtemp, ytemp, 0);

       
    }
}
