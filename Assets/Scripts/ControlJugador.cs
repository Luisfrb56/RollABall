using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour {

    public float ritmo;
    public Text countText;
    public Text winText;
    public Text tiempoText;
    public float tiempo = 0.0f;
    public Text tiempofinal;
    public bool prub=false;
    private Rigidbody rb;
    private int count;
   
     void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }


    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);

        rb.AddForce(movimiento * ritmo);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count>=12)
        {
            prub = true;
            winText.text = "VICTORIA!";
            
        }
    }
    
    public void Update()
    {
        
        if (prub == false)
        {
            tiempo = Time.time;
            tiempoText.text = "" + tiempo;
        }
        else
        {
            tiempoText.text = tiempo.ToString();
        }
       

    }

}
