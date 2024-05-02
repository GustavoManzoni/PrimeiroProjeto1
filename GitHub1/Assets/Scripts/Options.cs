using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{


    public GameObject canva;
    public GameObject opt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void opt1()
    {

        canva.SetActive(false);
        opt.SetActive(true);



    }
    public void opt2()
    {


        canva.SetActive(true);
        opt.SetActive(false);

    }

}
