using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_text : MonoBehaviour
{

    [SerializeField] Text Last;

    private void Update()
    {
        Last.text = "Last Score : " + Point.point;
    }
}
