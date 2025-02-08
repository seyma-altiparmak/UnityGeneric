using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAVA_PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    [SerializeField] private GameObject EndUI;

    private void Update() {
        Move();
    }

    void Move(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        rb.AddForce(move * speed*Time.deltaTime);
    }

    void Jump(){
        if(Input.GetKeyDown(KeyCode.Space) ){
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    void Dead(){
        if(transform.position.y < -10){
            Destroy(player);
            EndUI.SetActive(true);
    }
}
}
