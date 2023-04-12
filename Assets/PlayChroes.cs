using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayChroes : MonoBehaviour
{
    [SerializeField] AudioSource audioA;
    [SerializeField] AudioSource audioB;
    [SerializeField] AudioSource audioC;
    [SerializeField] AudioSource audioD;
    [SerializeField] AudioSource audioE;
    [SerializeField] AudioSource audioF;
    [SerializeField] AudioSource audioG;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "A")
        {
            audioA.Play(0);
        }else if (other.gameObject.name == "B")
        {
            audioB.Play(0);
        }
        else if (other.gameObject.name == "C")
        {
            audioC.Play(0);
        }
        else if (other.gameObject.name == "D")
        {
            audioD.Play(0);
        }
        else if (other.gameObject.name == "E")
        {
            audioE.Play(0);
        }
        else if (other.name == "F")
        {
            audioF.Play(0);
            Debug.Log("F note played");
        }
        else if(other.name== "G")
        {
            audioG.Play(0);
        }
        else
        {

        }
    }
}
