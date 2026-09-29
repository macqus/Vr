using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public int score = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet, firePoint.position, firePoint.rotation);
            b.GetComponent<Rigidbody>().AddForce(firePoint.forward * 500);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            score++;
            Destroy(other.gameObject);
        }
    }
}
