using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Auto_Movement : MonoBehaviour
{
    public float speed;
    public float currentT = 0f;
    public float startingT = 5f;

    [SerializeField] Text Counter;
    [SerializeField] GameObject CC;

    public Vector3 moveVector;
    private void Start()
    {
        currentT = startingT;
    }
    private void Update()
    {
        currentT -= 1 * Time.deltaTime;
        Counter.text = currentT.ToString();

        if (currentT < 0f)
        {
            CC.gameObject.SetActive(false);
            transform.Translate(moveVector * speed * Time.deltaTime);
        }
    }
}
