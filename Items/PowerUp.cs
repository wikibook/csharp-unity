using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item, IEffect
{
    public override void DestroyAfterTime()
    {
        Invoke("GetOpaque", 3f);
        Invoke("Destroy", 5f);
    }

    public override void ApplyItem()
    {
        
    }

    public void GetOpaque()
    {
        Color32 color = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(color.r, color.g, color.b, 50);
    }

    void Destroy(){
        Destroy(gameObject);
    }
}
