using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetect : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      Debug.Log("Down the Slopes brother");
    }
  }
}
