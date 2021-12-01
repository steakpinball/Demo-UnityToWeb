using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject attackPrefab;
    public float attackSpeed;
    [SerializeField] private Transform _attackSpawn;

    private void OnAttack(InputValue value)
    {
        var attack = Instantiate(attackPrefab, _attackSpawn.position, _attackSpawn.rotation);
        attack.GetComponent<Rigidbody>().velocity = attack.transform.forward * attackSpeed;
    }
}
