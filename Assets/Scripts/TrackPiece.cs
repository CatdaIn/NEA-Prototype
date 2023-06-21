using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPiece : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] trackPieces;
    // Start is called before the first frame update
    void Start()
    {
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprite(){
        spriteRenderer.sprite = trackPieces[Random.Range(0, trackPieces.Length)];
    }
}
