using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Target : MonoBehaviour
{
    public GameObject targetPrefab;
    public TextMeshProUGUI score;
    float minX;
    float maxX;
    float minY;
    float maxY;
    public bool isTargetAttack;
    public bool isGamePlaying;
    public int scoreInt;
    private void Awake()
    {
        isGamePlaying = true;
        scoreInt = 0;
        score.text = "SCORE : " + scoreInt + " / 10";
        minX = -0.4f;
        maxX = 0.4f;
        minY = -0.4f;
        maxY = 0.4f;
    }
    private void Start()
    {
        StartCoroutine(CreateTarget());
    }

    IEnumerator CreateTarget()
    {
        while (isGamePlaying == true)
        {
            var temp = Instantiate(targetPrefab,gameObject.transform);
            temp.GetComponent<TargetActive>().targetScript = this;
            temp.transform.localPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), -0.5f);
            isTargetAttack = false;
            yield return new WaitUntil(() => isTargetAttack == true);
            score.text = "SCORE : " + scoreInt + " / 10";
            Destroy(temp);
            if (scoreInt >= 10)
            {
                isGamePlaying = false;
                score.text = "°ÔÀÓ ½Â¸®!";
            }
        }
    }
}
