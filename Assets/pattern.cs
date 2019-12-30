using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattern : MonoBehaviour
{
    public GameObject[] obj;
    public float endposx,startposx,endposy,startposy,stepx=-2;
    public float stepy;
    public int[] ballarr; //ball Array
    public int l,rand,ly,gap;
    // Start is called before the first frame update
    void Start()
    {
        
       
        ly = 3;
        stepy = 4;
          for(int j=0;j<ly;j++)
        {
            rand = Random.Range(0,obj.Length);
            //  l = Random.Range(1,6);
            l=5;
           ballarr[j]=rand;
           Debug.Log(rand);
            
        for(int i=0;i<l;i++)
        {

           gap = Random.Range(0,2);
           Debug.Log(gap);
           if(gap==0)
           {
            Instantiate(obj[rand], new Vector2(stepx,stepy),this.transform.rotation);
            
           }
            stepx+=1;
        }
        stepx=-2;
         stepy-=1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
