using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class arrowtoskip : MonoBehaviour
{
    [SerializeField] private string newLevel;

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(newLevel);

        }
    }
}