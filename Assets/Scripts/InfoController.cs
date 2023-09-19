using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoController : MonoBehaviour
{
    public GameObject[] info;

    [Header("Options")]
    public GameObject Patent;
    public GameObject Copyright;
    public GameObject Trademark;
    public GameObject Continue;
    
    
    public int n=1;
    // Start is called before the first frame update
    void Start()
    {
        info[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnContinue()
    {
        n++;
        if(n<=4)
        {
            info[n-1].SetActive(false);
            info[n].SetActive(true);
        }
        else if(n ==5)
        {
            info[n-1].SetActive(false);
            Continue.SetActive(false);
            Patent.SetActive(true);
            Copyright.SetActive(true);
            Trademark.SetActive(true);
        }
        
        
    }

    public void OnPatentClick()
    {
        SceneManager.LoadScene(2);
    }

}
