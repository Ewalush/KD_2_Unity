using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    int i;
    Color customColor;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i==60){
            customColor = Random.ColorHSV();
            gameObject.GetComponent<MeshRenderer>().material.color = customColor;
            i=0;
        }
    }
}
