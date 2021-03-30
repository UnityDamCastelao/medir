using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Distancia : MonoBehaviour
{
    public Transform other;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private float count;
    void Start()
    {        
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    void Update()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            count = dist;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Distancia: " + count.ToString();
        winTextObject.SetActive(true);
    }
    
}
