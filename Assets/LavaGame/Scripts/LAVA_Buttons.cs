using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LAVA_Buttons : MonoBehaviour
{
    public void PlayAgainButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
