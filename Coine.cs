using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coine : MonoBehaviour
{
    public int coinValue = 0;
      private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player")) {
   ScoreManager.instance.ChangeScore(coinValue);
}
}
}
