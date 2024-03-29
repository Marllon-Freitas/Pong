using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
  protected Rigidbody2D _rigidbody;
  [SerializeField] protected float speed = 10f;

  private void Awake()
  {
    _rigidbody = GetComponent<Rigidbody2D>();
  }

  public void ResetPosition()
  {
    _rigidbody.velocity = Vector2.zero;
    _rigidbody.position = new Vector2(_rigidbody.position.x, 0f);
  }
}
