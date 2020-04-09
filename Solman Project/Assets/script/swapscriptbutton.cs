using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapscriptbutton : MonoBehaviour
{	public GameObject Skaf;
	public GameObject BackMainScene;
	
	
     public void ButtonSkafShow()
	{
	  
		BackMainScene.SetActive(true);
		Skaf.SetActive(false);
	}
	    public void ButtoexitskaffShow()
	{
	   
		BackMainScene.SetActive(false);
		Skaf.SetActive(true);
	}
}
