using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    static int point;

    [SerializeField] Text textpoint;


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
