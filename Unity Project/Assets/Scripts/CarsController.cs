using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarsController : MonoBehaviour
{

    [SerializeField]
    Object Car;
    [SerializeField]
    Sprite car,taxi,Police,Mini_van,Mini_truck,Ambulance;
    Sprite[] tab;
    Transform Position;
    Vector3 NewPos;
    GameObject enemy, Player;
    float[] positions;
    bool start;
    [SerializeField]
    GameObject UI,obj;
    int nbr,i= 0;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        tab = new Sprite[] { car, taxi, Mini_van, Mini_truck };
        positions = new float[] { -4, -1.25f, 1.15f, 3.8f };
        enemy = Instantiate(Car, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity) as GameObject;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            enemy = Instantiate(Car, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity) as GameObject;
            enemy.GetComponent<SpriteRenderer>().sprite = tab[Mathf.RoundToInt(Random.Range(0, 3))];
        }  

    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    /* public IEnumerator Police_Spawner()
    {
        start = false;
        Cops = Instantiate(PoliceCruiser, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity) as GameObject;
        yield return new WaitForSeconds(15.0f);
        Cops = Instantiate(PoliceCruiser, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity) as GameObject;
        Cops.GetComponent<SpriteRenderer>().sprite = Ambulance;
        start = true;
    }*/
    public void Play()
    {
        UI.SetActive(false);
        Time.timeScale = 1;
        obj.SetActive(true);
    }
}

