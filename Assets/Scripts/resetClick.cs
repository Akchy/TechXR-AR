using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class resetClick : MonoBehaviour, IPointerDownHandler
{
    public GameObject RealisticEgg, DummyEgg1, DummyEgg2, DummyEgg3, WinnerCanva;
    public GameObject StopImage, ResetImage, RotateEggs,Hammer;


	public void OnPointerDown( PointerEventData data )
	{
		RealisticEgg.GetComponent<Animator>().SetBool("cracked",false);
        DummyEgg1.GetComponent<Animator>().SetBool("cracked",false);
        DummyEgg2.GetComponent<Animator>().SetBool("cracked",false);
        DummyEgg3.GetComponent<Animator>().SetBool("cracked",false);
        WinnerCanva.GetComponent<Animator>().SetBool("winner",false);
        Hammer.GetComponent<Animator>().SetBool("hammer",false);
        //WinnerCanva.SetActive(false);
        ResetImage.SetActive(false);
        StopImage.SetActive(true);
        RotateEggs.GetComponent<Animator>().enabled=true;
        //RealisticEgg.GetComponent<Animator>().SetTrigger("reset");
        Debug.Log("OnPointerDown called. Davish " + data);
	}
    
}
