using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolcontroller : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject aim;
    public void Aim(GameObject tmp)
    {
       // aim=GameObeject.Find("");
    }
    // Update is called once per frame
    public Vector3 dir,test;
    void Update()
    {
        test = aim.transform.position;
        dir = aim.transform.position - this.transform.position;
        float angle_1 = 360 - Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle_1);
        this.transform.rotation = this.transform.rotation * Quaternion.Euler(0, 0, 5);
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
