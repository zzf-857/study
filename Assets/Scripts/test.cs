using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [Header("这是示例")]
    public float ss=2f;
    public float ss1 = 3f;

    [Space(20)]
    public float Space=20f;

    [Tooltip("hhhhh")]
    public float tooltop = 5f;

    [Range(0, 50)]
    public float Nn=50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
