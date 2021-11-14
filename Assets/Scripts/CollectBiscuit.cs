using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBiscuit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Score.theScore += 10;
        Destroy(gameObject);
    }
}
