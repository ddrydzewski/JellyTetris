using UnityEngine;

public class BlockCollision : MonoBehaviour
{

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// COLLISION ///
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public BlockScript Block;
    public MainScript Main;

    void OnTriggerEnter2D(Collider2D otherCollider2D)
    {
        if (Block.PlayerDropThisBlock == false)
        {
            if (otherCollider2D.gameObject.name == "PanelLeft" && Block.ChangeTurn == false)
            {
                Block.ChangeTurn = true;
                Block.BlockRigidbody2D.velocity = Vector2.zero;
            }

            if (otherCollider2D.gameObject.name == "PanelRight" && Block.ChangeTurn == true)
            {
                Block.ChangeTurn = false;
                Block.BlockRigidbody2D.velocity = Vector2.zero;
            }
        }
    }
}