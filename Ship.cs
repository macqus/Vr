using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 5f;
    public int health = 3;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * move);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Iceberg"))
        {
            health--;
            Debug.Log("Damage! Health: " + health);
        }
    }
}
