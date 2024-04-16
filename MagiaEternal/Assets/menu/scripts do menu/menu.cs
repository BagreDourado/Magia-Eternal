using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject op1;
    public GameObject op2;
    public void jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void op ()
    {
        op1.SetActive(false);
        op2.SetActive(true);
    }
    public void sairop()
    {
        op2.SetActive(false);
        op1.SetActive(true);
    }
    public void sair()
    {
        Application.Quit();
    }
}
