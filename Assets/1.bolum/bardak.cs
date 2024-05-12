using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public GameObject panelToShow;
    bool panelActive = false;
    void Start()
    {

    }

    public void ShowPanel()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            panelToShow.SetActive(true);
            panelActive = true;
        }
    }

    public void malzemeKontrol()
    {
        if (ekmek.color == Color.green && pirinc.color == Color.green && seker.color == Color.green && vitamin.color == Color.green && tuz.color == Color.green)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void HidePanel()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            panelToShow.SetActive(false);
            panelActive = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (panelActive)
        {
            HidePanel();
        }
        if (panelActive == false)
        {
            ShowPanel();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ekmek")
        {
            ekmeksayi++;
            ekmek.text = ekmeksayi.ToString();
            Debug.Log("ekmek alındı.");

            if ((ekmeksayi + pirincsayi) == 7)
            {
                ekmek.color = Color.green;
                pirinc.color = Color.green;
            }

            malzemeKontrol();
        }
        if (other.tag == "pirinc")
        {
            pirincsayi++;
            pirinc.text = pirincsayi.ToString();
            Debug.Log("pirinc alındı.");
            if ((ekmeksayi + pirincsayi) == 7)
            {
                ekmek.color = Color.green;
                pirinc.color = Color.green;
            }
            malzemeKontrol();
        }
        if (other.tag == "seker")
        {
            sekersayi++;
            seker.text = sekersayi.ToString();
            Debug.Log("seker alındı.");
            if (sekersayi == 7)
            {
                seker.color = Color.green;
            }
            malzemeKontrol();
        }
        if (other.tag == "tuz")
        {
            tuzsayi++;
            tuz.text = tuzsayi.ToString();
            Debug.Log("tuz alındı.");
            if (tuzsayi == 7)
            {
                tuz.color = Color.green;
            }
            malzemeKontrol();
        }
        if (other.tag == "vitamin")
        {
            vitaminsayi++;
            vitamin.text = vitaminsayi.ToString();
            Debug.Log("vitamin alındı.");
            if (vitaminsayi == 7)
            {
                vitamin.color = Color.green;
            }
            malzemeKontrol();
        }
    }
}
