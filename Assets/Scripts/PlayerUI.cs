using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _name;

    private void Start()
    {
        SetPlayerName("");
    }

    public void SetPlayerName(string newName)
    {
        _name.text = newName;
    }
}
