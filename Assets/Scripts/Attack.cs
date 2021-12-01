using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject.FindWithTag("GameController").GetComponent<GameController>().Score += 1;
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
