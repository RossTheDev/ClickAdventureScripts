﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudio : MonoBehaviour {

    // Use this for initialization
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Destroy(gameObject);


        }

    }
}
