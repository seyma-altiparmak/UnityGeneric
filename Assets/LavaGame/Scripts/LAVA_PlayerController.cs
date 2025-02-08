using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAVA_PlayerController : MonoSingleton<LAVA_PlayerController>
{
    [Header("Player Settings")]
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    [Header("UI Settings")]
    [SerializeField] private GameObject EndUI;

    void Start()
    {
        if (rb == null)
        {
            rb = player.GetComponent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        Jump();
        Dead();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = player.transform.right * x + player.transform.forward * z;
        rb.AddForce(move * speed, ForceMode.Force);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    void Dead()
{
    if (player == null) return; 

    if (player.transform.position.y < -10)
    {
        EndUI.SetActive(true);

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
        }

        player.SetActive(false);
    }
}

}
