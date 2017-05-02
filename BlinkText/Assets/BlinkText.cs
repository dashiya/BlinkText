using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour {

    public Text text;
    public MoveCube mc;

	// Use this for initialization
	void Start () {

        mc = GameObject.Find("MoveCube").GetComponent<MoveCube>();

       	}
	
	// Update is called once per frame
	void Update () {

        BlinkJudge();

	}

    void BlinkJudge()
    {
        if ( mc.isTouch == true)
        {
            gameObject.GetComponent<Text>().color = new Color(255, 255, 255, 1); 
        }
        if( mc.isTouch == false)
        {
            gameObject.GetComponent<Text>().color = new Color(0,0,0,0);
        }
    }

}
