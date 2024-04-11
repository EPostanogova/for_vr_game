using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public GameObject door;
    //Animator anim;
    Animation animat;
    private void Start()
    {
      // anim = door.GetComponent<Animator>();
      animat = door.GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider other)
    {
       // anim.SetBool("open",true);
       animat.Play();
    }
}
