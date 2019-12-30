using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject[] balls;
    //  public GameObject[] points_balls;
    public pattern pt;
     Collider2D[] col;
    private int rand;
    public string[] list;
    // Start is called before the first frame update
    void Start()
    {
      
     init();
    //  points_balls[0] = GetComponent<GameObject>();
    //  points_balls[1] = GetComponent<GameObject>();
    //  points_balls[2] = GetComponent<GameObject>();
     
// list = pt.ballarr.Distinct().ToArray();
    }

    // Update is called once per frame
    void Update()
    {
//          if(get_ball()==0 && points_balls[0].tag=="points_blue")
//         {
            
//             col[0] = points_balls[0].GetComponent<Collider2D>();
// col[0].isTrigger = true;
//         }
//         if(get_ball()==1 && points_balls[1].tag=="points_green")
//         {
//              col[1] = points_balls[1].GetComponent<Collider2D>();
// col[1].isTrigger = true;
// col[1].isTrigger = true;
//         }
//         if(get_ball()==2 && points_balls[2].tag=="ponts_yellow")
//         {
//              col[2] = points_balls[2].GetComponent<Collider2D>();
// col[2].isTrigger = true;
// col[2].isTrigger = true;
//         }
    }
    public void init()
    {
           rand = Random.Range(0,balls.Length);
        Debug.Log("started");
        Instantiate(balls[rand],this.transform.position,this.transform.rotation);
    }
    public int get_ball()
    {
        return rand;
    }
}
