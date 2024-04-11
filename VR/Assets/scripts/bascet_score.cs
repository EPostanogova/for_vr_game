using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bascet_score : MonoBehaviour
{
    public TMP_Text text;
    private int score;
    void Start()
    {
        score= 0;
       text.text = score.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("score"))
        {
            Destroy(other.gameObject);
            score ++;
            text.text = score.ToString();

        }
    }
    private void Update()
    {
            if (score==3)
        {
            text.text = "you win!!!!";
        }
    }

}
