using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 startpos,endpos,offset,targetdir;
    Camera cm;
    LineRenderer lr;
    Rigidbody2D rb;
     start st;
      Collider2D col;
     public GameObject start;
    Vector3 camoffset = new Vector3(0,0,0);
    [SerializeField] AnimationCurve ac;

    // public GameObject ball;
       // Start is called before the first frame update
    void Start()
    {
        // col = GetComponent<Collider2D>();
        cm = Camera.main;
st = GetComponent<start>();
lr = GetComponent<LineRenderer>();
rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
      if(rb.velocity== Vector2.zero)
      {
control();
      }
        
}
private void control()
{
  startpos = this.transform.position+camoffset;
        // Debug.Log(startpos);

        // if(Input.GetMouseButtonDown(0) )
        // {
//                             if(lr == null)
// {
//     lr = gameObject.AddComponent<LineRenderer>();

// }
    
lr.positionCount = 2;
lr.widthCurve = ac;
lr.numCapVertices = 10;
lr.enabled = false;
lr.SetPosition(0,startpos);
// lr.SetRotation(0,0,0);s
lr.useWorldSpace = true;
        // }
          if(Input.GetMouseButton(0)|| (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
              lr.enabled = true;
            endpos = cm.ScreenToWorldPoint(Input.mousePosition)+camoffset;
            lr.SetPosition(1,endpos);
        }
          if(Input.GetMouseButtonUp(0)|| (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            lr.enabled = false;
           targetdir =  endpos-startpos;
            rb.AddForce(targetdir*50);

        }
}
 private void OnCollisionEnter2D(Collision2D other) {
    if((other.gameObject.tag == "points_blue") && (this.gameObject.tag=="blue"))
    {
      //        col = other.gameObject.GetComponent<Collider2D>();
      // col.isTrigger = true;
       Destroy(other.gameObject);
 
    }
      if((other.gameObject.tag == "points_green") && (this.gameObject.tag=="green"))
    {
      //       col = other.gameObject.GetComponent<Collider2D>();
      // col.isTrigger = true;
       Destroy(other.gameObject);
      
    }
      if((other.gameObject.tag == "points_yellow") && (this.gameObject.tag=="yellow"))
    {
      //    col = other.gameObject.GetComponent<Collider2D>();
      // col.isTrigger = true;
       Destroy(other.gameObject);
         
    }
        if(other.gameObject.tag == "bottom")
    {
        
       Destroy(this.gameObject);
      //  st.init();
      start.GetComponent<start>().init();
    }
}
    }

