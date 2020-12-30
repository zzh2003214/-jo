using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dacongming : MonoBehaviour
{
    public GameObject enebullet;
    public Text win;
    public Text sm;
    // Start is called before the first frame update
    void Start()
    {
       // pistol.GetComponent < "Pistolcontroller" >().aim(this);
StartCoroutine(enu());
        Instantiate(sm, new Vector3(-270f,-27f,-0),Quaternion.Euler(0, 0, 0));
    }
    public int run = 0;
    public float timm = 5f;
    IEnumerator enu()
    {
        while (true)
        {
            ++run;
            run=run%5;
                if (run == 0) timm = 3f;
            else timm = 1f;
                Instantiate(enebullet, new Vector3(transform.position.x, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x, transform.position.y+1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x+2.5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x+2.5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x+2.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x-2.5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x-2.5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x-2.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 7.5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 7.5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 7.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 7.5f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 7.5f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 7.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 10f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 10f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x + 10f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 10f, transform.position.y - 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 10f, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(enebullet, new Vector3(transform.position.x - 10f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(timm);
        }
    }
    public float speed = 4.0f;
    public Vector3 dir=new Vector3(0,0,0);
    public float lx = -7.7f, rx = 8.0f, ly = 0f, ry = 8.62f;
    public int judge()
    {
        if (transform.position.x <= lx||transform.position.x >= rx || transform.position.y >= ry|| transform.position.y <= ly) return 1;
        return 0;
    }
    // Update is called once per frame
    void Update()
    {
        sm.text = life.ToString();
        int x = judge();
        if (dir == new Vector3(0, 0, 0) || x != 0)
        {
            float tmp = speed * Time.deltaTime;
            float a0 = tmp*Random.Range(-2f, -1f), a1 = tmp*Random.Range(1f, 2f),a3= Random.Range(-1f, 1f)<0?a1:a0, b0 = tmp*Random.Range(-2f, -1f)/2.0f, b1 = tmp*Random.Range(1f, 2f)/2.0f,b3 = Random.Range(-1f, 1f) < 0 ? b1 : b0;
            if (transform.position.x <= lx)
            {
                if (transform.position.y <= ly) dir = new Vector3(a1, b1,0);
                else if (transform.position.y >= ry) dir = new Vector3(a1, b0,0);
                else dir = new Vector3(a1, b3, 0);
            }
            else if (transform.position.x >= rx) 
            {
                if (transform.position.y <= ly) dir = new Vector3(a0, b1,0);
                else if (transform.position.y >= ry) dir = new Vector3(a0, b0,0);
                else dir = new Vector3(a0, b3, 0);
            }
            else if (transform.position.y <= ly) dir = new Vector3(a3, b1, 0);
            else if (transform.position.y >= ry) dir = new Vector3(a3, b0, 0);
            else dir = new Vector3(a3,b3, 0);
        }
        transform.position += dir;
    }
    private void win1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public int life = 1000;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="PlayerZD")
        {
            Destroy(collision.gameObject);
            if (life > 1) --life;
            else
            {
                gameObject.SetActive(false);
                Invoke("win1", 2f);
            }
        }
        if (collision.tag == "olaZD")
        {
            Destroy(collision.gameObject);
            if (life > 5) life-=5;
            else
            {
                gameObject.SetActive(false);
                Invoke("win1", 2f);
            }
        }
    }
}
