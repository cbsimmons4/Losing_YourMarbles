﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapController : MonoBehaviour
{
    public Text marbleCount;
    // Start is called before the first frame update
    void Start()
    {
        marbleCount=GameObject.Find("Marble Count").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("marble"))
        {
            Destroy(other.gameObject);
            marbleCount.text = (int.Parse(marbleCount.text) + 1).ToString();
            Destroy(this.gameObject);
        }
    }
}