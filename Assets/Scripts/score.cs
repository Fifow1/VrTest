using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text scoreText;
    int scoreInt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            scoreInt++;
            scoreText.text = scoreInt.ToString();        }
    }
}
