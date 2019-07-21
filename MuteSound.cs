using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour {

    void Update()
    {

        if (Input.GetKey(KeyCode.M))
        {
            Destroy(gameObject);
        }
    }
}