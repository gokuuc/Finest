using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    public static int point;

    private int start = 0;

    [SerializeField] Text textpoint;

    private void Start()
    {
        point = start;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            point += 10;
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        textpoint.text = point.ToString();
    }
}
