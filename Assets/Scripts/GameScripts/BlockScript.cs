using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public Rigidbody2D BlockRigidbody2D;

    public bool PlayerDropThisBlock { get; set; }
    public bool ChangeTurn { get; set; }
    public float PlayerRotation { get; set; }

    void Start()
    {
        BlockRigidbody2D.mass = 0;
        BlockRigidbody2D.gravityScale = 0;
        PlayerDropThisBlock = false;
        ChangeTurn = false;
    }

    void Update()
    {
        if (PlayerDropThisBlock == false)
        {
            BlockRigidbody2D.rotation += PlayerRotation;
            if (ChangeTurn == false)
            {
                BlockRigidbody2D.velocity -= new Vector2(0.2f, 0);
            }
            else
            {
                BlockRigidbody2D.velocity += new Vector2(0.2f, 0);
            }
        }
    }
}
