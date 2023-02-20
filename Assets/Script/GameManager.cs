using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int nyawa = 3;

    public static void Dead(){
        nyawa--;
        if(nyawa == 0){
            return;
        }
        SceneManager.LoadScene("Main");
    }


}
