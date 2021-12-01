using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomGuaiwu : MonoBehaviour
{
    //生成的预制体
    public GameObject gm;
    public GameObject zhongdian;
    public Vector3 center = Vector3.zero;
    public float waitetime = 1f;
    public int count = 20;
    private float effect = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Guaiwushengcheng());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)&& count <= 0)
        {
            count = 20;
            StartCoroutine(Guaiwushengcheng());
        }
    }

    private IEnumerator Guaiwushengcheng()
    {
        var waite = new WaitForSeconds(waitetime);
        while (count > 0)
        {
            GameObject guai = gm;
            var pos = new Vector3(Random.Range(center.x - effect, center.x + effect), 0f, Random.Range(center.z - effect, center.z + effect));
            Instantiate(guai, pos, transform.rotation);
            count--;
            yield return waite;
        }
    }
}
