using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDeadHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            LogicScript.instance.GameOver();
        }
    }
}
