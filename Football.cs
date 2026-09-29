using UnityEngine;

public class Football : MonoBehaviour
{
    public Rigidbody ball;
    public int score = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ball.AddForce(Vector3.forward * 500);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score++;
            Debug.Log("Goal! Score: " + score);
        }
    }
}
