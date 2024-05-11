using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bardak : MonoBehaviour
{
    [SerializeField] Text ekmek;
    int ekmeksayi = 0;
    [SerializeField] Text pirinc;
    int pirincsayi = 0;
    [SerializeField] Text tuz;
    int tuzsayi = 0;
    [SerializeField] Text seker;
    int sekersayi = 0;
    [SerializeField] Text vitamin;
    int vitaminsayi = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ekmek")
        {
            ekmeksayi++;
            ekmek.text = ekmeksayi.ToString();
            Debug.Log("ekmek alındı.");
        }
        if (other.tag == "pirinc")
        {
            pirincsayi++;
            pirinc.text = pirincsayi.ToString();
            Debug.Log("pirinc alındı.");
        }
        if (other.tag == "seker")
        {
            sekersayi++;
            seker.text = sekersayi.ToString();
            Debug.Log("seker alındı.");
        }
        if (other.tag == "tuz")
        {
            tuzsayi++;
            tuz.text = tuzsayi.ToString();
            Debug.Log("tuz alındı.");
        }
        if (other.tag == "vitamin")
        {
            vitaminsayi++;
            vitamin.text = vitaminsayi.ToString();
            Debug.Log("vitamin alındı.");
        }
    }
}