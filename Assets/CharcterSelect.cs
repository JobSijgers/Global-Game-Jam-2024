using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterSelect : MonoBehaviour
{

    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject UI;
    public void SelectCharacter(GameObject character)
    {
        Instantiate(character, spawnLocation.position, Quaternion.identity);
        UI.SetActive(false);
    }
}
