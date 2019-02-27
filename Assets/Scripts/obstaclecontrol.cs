using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclecontrol : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject Obj_Position;
    int count = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        count = Random.Range(1, 4);
     if(col.gameObject.tag=="Obstacles")

        {
            if (count == 1)
            {
                Instantiate(obj1, Obj_Position.transform.position, Quaternion.identity);
            }
            else if (count == 2)
            {
                Instantiate(obj2, Obj_Position.transform.position, Quaternion.identity);
            }
            else if (count == 3)
            {
                Instantiate(obj3, Obj_Position.transform.position, Quaternion.identity);
            }
            else if(count == 4)
            {
                Instantiate(obj4, Obj_Position.transform.position, Quaternion.identity);
            }
            Destroy(col.gameObject);
        }  
    }
   /* private GUIStyle guiStyle = new GUIStyle();
    void OnGUI()
    {
        guiStyle.fontSize = 20;
        //guiStyle. = Color.black;
        GUI.Label(new Rect(10, 10, 100, 20), "The number that was generated: " + count, guiStyle);
        
    }*/
}
