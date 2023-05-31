using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask floorLayerMask;
    private Rigidbody2D rb;
    private BoxCollider bc;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dirX * 5f, rb.velocity.y);

        if (IsGounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool IsGounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down * .1f, floorLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
}
