using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isfacingRight = true;

    public CollectableManager CollectableManager;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform Groundcheck;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private Animator animator;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }

        Flip();

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isRunning", true);
            //Debug.Log("true");
        }
        else
        {
            animator.SetBool("isRunning", false);
            //Debug.Log("false");
        }

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(Groundcheck.position, 0.2f, groundlayer);
    }

    private void Flip()
    {
        if (isfacingRight && horizontal < 0f || !isfacingRight && horizontal > 0f)
        {
            isfacingRight = !isfacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            CollectableManager.collectableCount++;
        }
    }
}
