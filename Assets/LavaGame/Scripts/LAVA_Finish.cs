using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAVA_Finish : MonoBehaviour
{
        public GameObject CongratsUI;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            CongratsUI.SetActive(true);
        }
    }
}
