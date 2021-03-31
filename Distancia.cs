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
    private LineRenderer line;
    void Start()
    {        
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        // Add a Line Renderer to the GameObject
         line = this.gameObject.AddComponent<LineRenderer>();
         // Set the width of the Line Renderer
         line.SetWidth(0.05F, 0.05F);
         // Set the number of vertex fo the Line Renderer
         line.SetVertexCount(2);
    }
    void Update()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            count = dist;
            SetCountText();
            line.SetPosition(0, other.transform.position);
            line.SetPosition(1, transform.position);
        }
    }
    void SetCountText()
    {
        countText.text = "Distancia: " + count.ToString() + " metros";
        winTextObject.SetActive(true);
    }
    
}
