using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class img : MonoBehaviour
{
    public GameObject image;
    private int total = 0;
    void Update()
    {
        if(total==4)
        {
            image.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("cube"))
        {
            total++;
            Destroy(collision.gameObject);
        }
            

    }
}
