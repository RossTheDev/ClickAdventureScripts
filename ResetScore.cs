using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScore : MonoBehaviour
{
    public Image image;


    private void Start()
    {
        image.enabled = false;
    }

    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ScoreScript.scoreValue = 0;
            //reset score image here
            image.enabled = true;
        }

    }
}
