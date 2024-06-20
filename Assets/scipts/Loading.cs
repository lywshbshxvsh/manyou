using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Image image;
    float t = 0;
    public Sprite[] sprites = new Sprite[3];
    int index = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        image = image.GetComponent<Image>();
        image.sprite = sprites[index];
       
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
            index++;
            if (index == sprites.Length)
            {
                index = 0;
            }
            image.sprite = sprites[index];
        }
        
    }
}

