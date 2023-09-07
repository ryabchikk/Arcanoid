using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    [SerializeField] private Text text;
    
    [HideInInspector] public int count;

    private void Start()
    {
        text.text = count.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {

        if (count<=0) { 
            Destroy(this.gameObject);
        }
        else
        {
            count--;
        }
    }
}
