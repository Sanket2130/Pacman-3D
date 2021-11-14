using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
   public GameObject scoreText;
   public static int theScore;

   private void Update()
   {
      scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE: " + theScore;
   }
}
