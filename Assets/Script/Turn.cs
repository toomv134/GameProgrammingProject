using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public static Turn instance;

    public float Phase;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Duplicated Turn, ignoring this one", gameObject);
        }
    }

    private void Start()
    {

    }

    public void Turn_Start()
    {

    }


    public void Phase2() //건물, 유닛 생산, 연구
    {
        Debug.Log("Phase2 start");
        SceneManager.LoadScene("Map");
    }
    public void Phase3() // 3Day부터 공격여부 결정
    {
        Debug.Log("Phase3 start");
        SceneManager.LoadScene("Phase3");
    }

    public void Turn_End()
    {

        //Day++;
    }
}
