using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DestroyByBasket : MonoBehaviour
{
    public Text countText;
    public Text winText;

    private int count;

  void Start()
    {
        count = 0;
        SetCountText();
    }
      
   
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Egg"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "Level: ";
        }
    }

}
