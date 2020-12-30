using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randDJ : MonoBehaviour
{
    public Transform DJ1,DJ2,DJ3;
    public float jg=7;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enu());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator enu()
    {
        while (true)
        {
            float rd = Random.Range(0f, 4f);
            if(rd<=1)
            {
            Transform transform1 = Instantiate(DJ1);
            float x = Random.Range(-7f, 7f);
            transform1.position = new Vector3(x, 10, 0);
            }
            if (rd > 1 && rd < 2)
            {
                Transform transform1 = Instantiate(DJ2);
                float x = Random.Range(-7f, 7f);
                transform1.position = new Vector3(x, 10, 0);
            }
            if (rd >=2 && rd < 3)
            {
                Transform transform1 = Instantiate(DJ3);
                float x = Random.Range(-7f, 7f);
                transform1.position = new Vector3(x, 10, 0);
            }
            yield return new WaitForSeconds(jg);
        }
    }
}
