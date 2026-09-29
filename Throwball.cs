using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public Rigidbody ball;
    public int score = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ball.AddForce(Vector3.forward * 500);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pin"))
        {
            score++;
            Debug.Log("Pin hit! Score: " + score);
        }
    }
}
