using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite;
    [SerializeField] int hp = 4;
    public AudioClip chopSound1;
    public AudioClip chopSound2;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void DamageWall (int loss)
    {
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        SoundManager.instance.RandomizeSfx(chopSound1, chopSound2);
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
