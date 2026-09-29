using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        controller.Move(movement * speed * Time.deltaTime);
    }
}
