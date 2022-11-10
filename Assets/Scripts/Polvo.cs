using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polvo : MonoBehaviour
{
    public GameObject bolaTinta;
    public Transform saidaTiro;
    public Transform saidaTiro2;
    public float Speed = 5;

    private bool tiro;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Atirar", .01f, 2f);
        InvokeRepeating("AtirarBola2", .2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Atirar(){
        GameObject temp = Instantiate(bolaTinta);
        temp.transform.position = saidaTiro.position;
        //temp.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        temp.GetComponent<Rigidbody2D>().velocity = new Vector2(-1*Speed, 0);
        Destroy(temp.gameObject, 5f);
    }

    void AtirarBola2(){
        GameObject temp2 = Instantiate(bolaTinta);
        temp2.transform.position = saidaTiro2.position;
        //temp.transform.Translate(Vector3.left * Speed * Time.deltaTime);
        temp2.GetComponent<Rigidbody2D>().velocity = new Vector2(-1*Speed, 0);
        Destroy(temp2.gameObject, 5f);
    }
}
