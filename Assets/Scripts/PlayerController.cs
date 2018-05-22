using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
   

    void Start() {

        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";    
    }

    void FixedUpdate() {

        float veritcalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalMovement, 0, veritcalMovement);
        rb.AddForce(movement * speed);


    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("pickup")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText() {

        if (count == 10) {
            winText.text = "You win!";
        }
        countText.text = "Count: " + count.ToString();
    }

}
