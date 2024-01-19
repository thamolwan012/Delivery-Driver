using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ahh!!!");
    }
    void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.tag == "Packge" && !hasPackage)
        {
          Debug.Log("เย้ ทำได้ดีมาก");
          hasPackage = true;
          spriteRenderer.color = hasPackageColor;
          Destroy(other.gameObject, destroyDelay);
        }
        //if (other.tag == "Customer")

        //    Debug.Log("Goooooodd!!");
        //}
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("ส่งสำเร็จ!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
     }   
    }

