using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float torqueAmount = 2.5f;
  Rigidbody2D snowboarderBody;

  void Start()
  {
    snowboarderBody = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      snowboarderBody.AddTorque(torqueAmount);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      snowboarderBody.AddTorque(-torqueAmount);
    }
  }
}
