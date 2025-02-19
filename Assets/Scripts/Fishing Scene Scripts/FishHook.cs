using UnityEngine;

public class FishHook : MonoBehaviour
{
    public static FishHook HookInstance;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(dirX * 5f, dirY * 5f);


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("fish1"))
        {
            GlobalGameManager.Instance.PlayerStats.AddCoins(1);
        } else if (other.gameObject.name.Equals("fish2"))
        {
            GlobalGameManager.Instance.PlayerStats.AddCoins(2);
        } else if (other.gameObject.name.Equals("fish3"))
        {
            GlobalGameManager.Instance.PlayerStats.AddCoins(3);
        }
        else if (other.gameObject.name.Equals("fish4"))
        {
            GlobalGameManager.Instance.PlayerStats.AddCoins(4);
        }
        Destroy(other.gameObject);
    }
}
