using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    AudioSource audioSource;

    public GameObject winner;
    public AudioClip onWin, onCrack;
    public GameObject hammer;
    private void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void Update() {
        
    }

    private void OnTriggerEnter(Collider other) {
        audioSource.PlayOneShot(onCrack);
        this.gameObject.GetComponent<Animator>().SetBool("cracked",true);
        if(this.gameObject.name=="Realistic Egg"){
            audioSource.PlayOneShot(onWin);
            winner.SetActive(true);
            winner.GetComponent<Animator>().SetBool("winner",true);
        }
        
    }

}
