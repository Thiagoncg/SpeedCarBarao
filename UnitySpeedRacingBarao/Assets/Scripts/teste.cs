using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(50f, 50f, 50f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,50f * Time.deltaTime,0f);
    }
}