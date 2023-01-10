using UnityEngine;

public class ComputerPaddle : Paddle
{
  public Rigidbody2D ball;

  private void FixedUpdate()
  {
    if (ball.velocity.x > 0f)
    {
      if (ball.position.y > _rigidbody.position.y)
      {
        _rigidbody.AddForce(Vector2.up * speed);
      }
      else if (ball.position.y < _rigidbody.position.y)
      {
        _rigidbody.AddForce(Vector2.down * speed);
      }
    }
    else
    {
      if (_rigidbody.position.y > 0f)
      {
        _rigidbody.AddForce(Vector2.down * speed);
      }
      else if (_rigidbody.position.y < 0f)
      {
        _rigidbody.AddForce(Vector2.up * speed);
      }
    }
  }

}