using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daojishi : MonoBehaviour
{
    public float time = 100;

    public Text text;

    private void Start()
    {
        text = transform.Find("Text").GetComponent<Text>();

        text.text = $"{(int)time / 60:D1}:{(int)time % 60:D2}";

        StartCoroutine(Count());
    }

    private IEnumerator Count()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            text.text = $"{(int)time / 60:D1}:{(int)time % 60:D2}";
        }
    }
}

