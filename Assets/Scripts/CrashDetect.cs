using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetect : MonoBehaviour
{
  [SerializeField] float timeToReload = 0.5f;

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Environment")
    {
      Invoke("ReloadScene", timeToReload);
    }
  }

  void ReloadScene()
  {
      SceneManager.LoadScene(0);
  }
}
