using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  private Rigidbody2D _rigidbody;

  [SerializeField] private float speed = 200f;

  private void Awake()
  {
    _rigidbody = GetComponent<Rigidbody2D>();
  }

  public void AddStartingForce()
  {
    float x = Random.value < 0.5f ? -1 : 1;
    float y = Random.value < 0.5f ? Random.Range(-1, -0.5f) : Random.Range(0.5f, 1);
    Vector2 direction = new Vector2(x, y).normalized;
    _rigidbody.AddForce(direction * speed);
  }

    public void ResetPosition()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.position = Vector2.zero;
    }

  public void AddForce(Vector2 force)
  {
    _rigidbody.AddForce(force);
  }
}
