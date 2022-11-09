using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca para manipular cenas

public class BolaTintaPolvo : MonoBehaviour
{
    
    public float destroyTime =  1.5f;
    public string cena;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(collider.gameObject, 0.2f);
            SceneManager.LoadScene(cena);
        }
    }
}
