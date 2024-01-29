using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PusherMachine : MonoBehaviour
{
    [SerializeField] private GameObject[] pistons;
    [SerializeField] private Vector3[] begins;
    [SerializeField] private Vector3[] targets;
    [SerializeField] private float distance;

    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private float[] pistonSpeed;
    [SerializeField] private bool[] movingOut;

    private void Start()
    {

        pistonSpeed = new float[pistons.Length];
        movingOut = new bool[pistons.Length];
        begins = new Vector3[pistons.Length];
        targets = new Vector3[pistons.Length];
        for (int i = 0; i < pistons.Length; i++)
        {
            begins[i] = pistons[i].transform.position;
            targets[i] = pistons[i].transform.position + pistons[i].transform.right  * distance;
            pistonSpeed[i] = Random.Range(minSpeed, maxSpeed); 
        }
    }
    private void Update()
    {
        for (int i = 0; i < pistons.Length; i++)
        {
            if (movingOut[i] == true)
            {
                pistons[i].transform.position = Vector3.MoveTowards(pistons[i].transform.position, targets[i], pistonSpeed[i] * Time.deltaTime);
                if (Vector3.Distance(pistons[i].transform.position, targets[i]) < 0.1f)
                {
                    movingOut[i] = false;
                }
            }
            else
            {
                pistons[i].transform.position = Vector3.MoveTowards(pistons[i].transform.position, begins[i], pistonSpeed[i] * Time.deltaTime);
                if (Vector3.Distance(pistons[i].transform.position, begins[i]) < 0.1f)
                {
                    movingOut[i] = true;
                }
            }
        }
    }


}
