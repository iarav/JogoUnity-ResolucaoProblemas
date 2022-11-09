using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca para manipular cenas

public class restart : MonoBehaviour
{
    public void JogarNovamente(string cena1)
    {
        SceneManager.LoadScene(cena1); //ao clicar no botao carrega a Cena1
    }
}
