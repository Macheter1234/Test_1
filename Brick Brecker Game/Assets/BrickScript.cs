using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int points;
    public int hitsToBreak;
    public int brickHits;
    public Sprite hitSprite;
    public Sprite hitSprite_2;

    public void BreakBrick()
    {
        hitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprite;
    }

    public void BreakBrick_2()
    {
        hitsToBreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprite_2;
    }
}
