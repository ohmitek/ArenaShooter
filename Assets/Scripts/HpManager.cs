using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpManager : MonoBehaviour
{

    public Text hpText;
    public int playerHP_number = 100;
    // Start is called before the first frame update
    void Start()
    {
        hpText.text = playerHP_number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Up_Date_Player_Hp();

        }
        
    }

    private void Up_Date_Player_Hp()
    {
        playerHP_number = playerHP_number - 10;
        hpText.text = playerHP_number.ToString();
    }
}
