﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{


    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ScoreScript.scoreValue += 1;
        }

    }
}
