using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action1 : MonoBehaviour
{
	public GameObject player1;
    public GameObject stage1;
    public GameObject stage2;
	//public Slider Slider;
	//public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animplay(string animClipName)
    {
        player1 = GameObject.Find("X Bot@T-Pose");
        player1.transform.position = new Vector3(-0.000122070313f,-1.50604248f,0.647888184f);
        if  (player1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length >
               player1.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime) 
        {

    	   player1.GetComponent<Animator>().Play(animClipName);
        }
    }
    public void animspeed(Slider slider)
    {	
    	//Slider = GameObject.Find("Slider");
    	//speed = Slider.value;
    	player1 = GameObject.Find("X Bot@T-Pose");
    	player1.GetComponent<Animator>().speed = slider.value;
    }


    public void goon()
    {
    	player1 = GameObject.Find("X Bot@T-Pose");
    	player1.GetComponent<Animator>().speed = 1f;

    }

    public void pause()
    {
    	player1 = GameObject.Find("X Bot@T-Pose");
    	player1.GetComponent<Animator>().speed = 0f;

    }
   public void changestage()
    {   
        
        stage1 = GameObject.Find("P_Showroom_01");
        stage2 = GameObject.Find("Terrain");

        if (stage1.GetComponent<Transform>().position.y == -1.506042f &&
            stage2.GetComponent<Transform>().position.y != -4.5999999f)

            {
                stage1.GetComponent<Transform>().position = new Vector3(0.200000003f,-100.506042f,-0.5f);
                stage2.GetComponent<Transform>().position = new Vector3(-151.699997f,-4.5999999f,-121.800003f);

            }
        else
        {
                stage1.GetComponent<Transform>().position = new Vector3(0.200000003f,-1.506042f,-0.5f);
                stage2.GetComponent<Transform>().position = new Vector3(-151.699997f,-100.5999999f,-121.800003f);


        }
       



    }

}
