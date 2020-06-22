using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int hp = 100;
    int damage = 25;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp = hp - damage;
        if (hp <= 0)
        {
            Debug.Log("game over");
        }
    }
}
