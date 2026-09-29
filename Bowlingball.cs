using UnityEngine;

public class Bowling : MonoBehaviour
{
    public Rigidbody ball;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ball.AddForce(Vector3.forward * 500);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pin"))
            Debug.Log("Pin Hit!");
    }
}
