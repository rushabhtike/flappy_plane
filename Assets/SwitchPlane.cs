using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlane : MonoBehaviour {
    public Sprite Red;
    public Sprite Green;

    public void Update()
    {
       

    }
    public void switchPlane()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Red)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Green;
            return;
        }
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Green)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Red;
            return;
        }
    }

}
