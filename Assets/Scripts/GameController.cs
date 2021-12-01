using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnLocations;

    public float delay = 10;

    private int _score;

    [DllImport("__Internal")]
    private static extern void SetScore(int score);
    
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            SetScore(_score);
        }
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            var loc = spawnLocations[Random.Range(0, spawnLocations.Length)];
            Instantiate(enemy, loc.position, loc.rotation);
        }
    }
}
