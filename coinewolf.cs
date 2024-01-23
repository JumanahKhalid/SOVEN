using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinewolf : MonoBehaviour
{
    public int coinValue = 0;
      private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("PlayerCtrl")) {
   ScoreManager.instance.ChangeScore(coinValue);
}
}
}
