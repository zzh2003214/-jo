using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randenemy : MonoBehaviour
{
    public AudioSource mus1, mus2;
    public Transform Enemy,dacongming;
    public float jg;
    public int tmp = 0;
    // Start is called before the first frame update
    void Start()
    {
        mus2.Stop();
        mus1.Stop();
        StartCoroutine(enu());
    }
    public int run = 0;
    public float timm = 5f;
    IEnumerator enu1()
    {
        while (true)
        {
            ++run;
            run = run % 5;
            if (run == 1) mus2.Play();
            if (run == 0) { timm = 3f; }
            else timm = 1f;
            yield return new WaitForSeconds(timm);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator enu()
    {
        while (true)
        {
            ++tmp;
            if (tmp <= 3)
            {
                Transform transform1 = Instantiate(Enemy);
                float x = Random.Range(-7f, 7f),y= Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);
                transform1 = Instantiate(Enemy);
                x = Random.Range(-7f, 7f); y = Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);
            }
            if(tmp>3&&tmp<=5)
            {
                Transform transform1 = Instantiate(Enemy);
                float x = Random.Range(-7f, 7f), y = Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);
                transform1 = Instantiate(Enemy);
                x = Random.Range(-7f, 7f); y = Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);
                transform1 = Instantiate(Enemy);
                x = Random.Range(-7f, 7f); y = Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);
            }
            if (tmp == 6)
            {
                StartCoroutine(enu1());
                mus1.Play();
                Transform transform1 = Instantiate(dacongming);
                float x = Random.Range(-7f, 7f), y = Random.Range(2f, 8f);
                transform1.position = new Vector3(x, y, 0);

            }
            yield return new WaitForSeconds(jg);
        }
    }
}
