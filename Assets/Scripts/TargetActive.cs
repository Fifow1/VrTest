using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetActive : MonoBehaviour
{
    public Target targetScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Á¡¼ö? !!");
            targetScript.isTargetAttack = true;
            targetScript.scoreInt += 1;
        }
    }
}
