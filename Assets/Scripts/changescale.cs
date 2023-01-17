using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changescale : MonoBehaviour
{	
	public float scale;
	public GameObject bot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeS (Slider slider)
    {
    	scale = slider.value;
    	bot = GameObject.Find("X Bot@T-Pose");
    	bot.transform.localScale = new Vector3(scale,scale,scale);
    }
}
