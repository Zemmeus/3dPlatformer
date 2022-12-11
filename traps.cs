using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        other.GetComponent<Jump>().jumpStrength /= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        other.GetComponent<Jump>().jumpStrength *= speedFactor;
    }
}
