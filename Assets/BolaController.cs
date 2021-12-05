
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaController : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    public Text textCount;
    public Text textWin;
    private int count;

    // Mensetup Bola agar bisa di gerakkan ke segala arah
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidbody.AddForce(movement * speed * Time.deltaTime);
    }

    // Mensetup Bola disaat bola menyentuh capsul, capsul dapat menghilang/terelimiinasi
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Pick") {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetTextCount();
        }
    }

    // Mensetup nilai disaat bola menyentuh object(capsul)
    void Start() {    
        count = 0;
        SetTextCount();
        textWin.text = "";        
    }

    void SetTextCount() {
        textCount.text = "Jumlah Capsul : " + count.ToString();
        if (count >= 13) {
            textWin.text = "Menang!";
        }
    }    
}
