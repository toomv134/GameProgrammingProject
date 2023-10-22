using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagaer : MonoBehaviour
{
    public static GameManagaer instance;

    public GameObject Player;
    public GameObject Enemy;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("게임 매니저가 두개이상!");
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Life>().amount <= 0) //Player lose
        {

        }
        else if (Enemy.GetComponent<Life>().amount <= 0) //Enemy lose
        {

        }
    }

    void Phase1() //전날이랑 비교
    {

    }
    void Phase2() //건물, 유닛 생산, 연구
    {

    }
    void Phase3() // 3Day부터 공격여부 결정
    {

    }
}
