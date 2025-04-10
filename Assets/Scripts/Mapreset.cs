using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mapreset : MonoBehaviour
{
    public GameObject ballPrefab;
    public Target target;
    public bool isBallOn;

    private void Start()
    {
        StartCoroutine(ballCor());
    }

    IEnumerator ballCor()
    {
        while (target.isGamePlaying == true)
        {
            var temp = Instantiate(ballPrefab);
            temp.GetComponent<Ball>().Mapreset = this;
            isBallOn = true;
            yield return new WaitUntil(()=> isBallOn ==false);
            Destroy(temp);
        }
    }
}
