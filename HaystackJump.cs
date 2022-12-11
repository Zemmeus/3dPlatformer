using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaystackJump : MonoBehaviour
{
    public float jumpFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}
