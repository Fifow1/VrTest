using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Mapreset Mapreset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BallGround")
        {
            if (Mapreset != null)
            {
                Mapreset.isBallOn = false;
            }
        }
    }
}
