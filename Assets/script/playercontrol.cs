using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour
{
    public AudioSource ola,olacollect,ms2;
    public int life = 3;
    public float speed =12f;
    public int level = 1;
    public bool haveola = false;
    public GameObject bullet, lose,pistol,olabullet;
    public Text sm;
    //bool ziyan = false;
    // Start is called before the first frame update
    public AudioSource bgm,dead;
    void bgmplay()
    {
        bgm.Play(); ola.Stop();dead.Stop(); olacollect.Stop();ms2.Stop();
    }
    void Start()
    {
        InvokeRepeating("bgmplay", 0, 60*5+20);
        lose.SetActive(false);
        sm.text = "生命：" + life.ToString();
        StartCoroutine(shoot());
    }
   /* void Pistol()
    {
        Instantiate(pistol, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
    }
   */
    int tmp = 0;
    IEnumerator shootola()
    {
        while (true)
        {
            ++tmp;
            if(tmp%40==0)
            ola.Play();
            if(tmp%40<10)Instantiate(olabullet, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator shoot()
    {
        while (true)
        {
            if(level==1)
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y+1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
            if (level == 2)
            {
            Instantiate(bullet, new Vector3(transform.position.x-1f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
            Instantiate(bullet, new Vector3(transform.position.x+1f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));

            }
            if (level >= 3)
            {
                Instantiate(bullet, new Vector3(transform.position.x - 1.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(bullet, new Vector3(transform.position.x , transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
                Instantiate(bullet, new Vector3(transform.position.x + 1.5f, transform.position.y + 1.5f, transform.position.z), Quaternion.Euler(0, 0, 0));
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //向上移动
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 8.46f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        //向下移动
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -8.45f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        //向左移动
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -7.67f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //向右移动
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.11f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    private void Lose2()
    {
        dead.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
        private void Lose1()
    {
        olacollect.Stop();
                bgm.Stop();
                dead.Play();
        lose.SetActive(true);
        Invoke("Lose2", 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemyZD")
        {
                Destroy(collision.gameObject);
            --life;
            sm.text = "生命：" + life.ToString();
            if (life <= 0)
            {
                Invoke("Lose1", 1.5f);
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (collision.tag == "ola")
        {
            Destroy(collision.gameObject);
            if(!haveola)
            {
            haveola = true;
            olacollect.Play();
            StartCoroutine(shootola());
            }
        }
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            life-=5;
            sm.text = "生命：" + life.ToString();
            if (life <= 0)
            {
                Invoke("Lose1", 1.5f);
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (collision.tag == "dacongming")
        {
            life -= 10;
            sm.text = "生命：" + life.ToString();
            if (life <= 0)
            {
                Invoke("Lose1", 1.5f);
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (collision.tag == "enemyZD")
        {
            Destroy(collision.gameObject);
            --life;
            sm.text = "生命：" + life.ToString();
            if (life <= 0)
            {
                olacollect.Play();
                Invoke("Lose1", 0.5f);
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (collision.tag == "FQ")
        {
            Destroy(collision.gameObject);
            life=life+3;
            sm.text = "生命：" + life.ToString();
        }
        if (collision.tag == "YM")
        {
            Destroy(collision.gameObject);
            ++level;
        }
    }
}
