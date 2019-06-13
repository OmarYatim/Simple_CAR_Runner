using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarScript : MonoBehaviour {

    [SerializeField]
    Sprite Audi;
    [SerializeField]
    Sprite Truck;
    [SerializeField]
    Sprite Viper;
    [SerializeField]
    Text liv;
    [SerializeField]
    Text text;
    [SerializeField]
    GameObject panel;
    protected float speed;
    protected Vector3 position;
    protected int lives;
    public float score = 0;

    public virtual void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Audi;
        position = new Vector3(0, -3.6f, 0);
        transform.position = position;
    }
    void Update()
    {
        Scoring();
        Movement();
        death();
    }
    public virtual void Movement()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal"), speed * Input.GetAxis("Vertical"), 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
            lives--;
    }
    void death()
    {
        liv.text = "" + lives;
        if(lives == 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            score = 0;
            panel.SetActive(true);
        }
    }
    void Scoring()
    {
        score += Time.deltaTime; 
        text.text = "" + Mathf.RoundToInt(score);
        if(score >= 20 && score < 40)
        {
            gameObject.GetComponent<AudiScript>().enabled = false;
            gameObject.GetComponent<ViperSript>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = Viper;
        }
        if (score >= 40)
        {
            gameObject.GetComponent<ViperSript>().enabled = false;
            gameObject.GetComponent<TruckScript>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = Truck;
        }
    }

}
