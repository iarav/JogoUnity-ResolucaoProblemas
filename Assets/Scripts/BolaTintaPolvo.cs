using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaTintaPolvo : MonoBehaviour
{

    public float Speed = 10;
    public float destroyTime =  1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObj", 0f, 2f);
        //Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag=="Player"){
            Destroy(col.gameObject, destroyTime);
        }
    }

    void CreateObj(){
        Instantiate(gameObject,transform.position,transform.rotation);
    }
}
