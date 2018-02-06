using UnityEngine;

namespace BlockDodge
{
    public class Player : MonoBehaviour
    {
        public float speed = 15f;
        public float mapWidth = 5f;

        private Rigidbody2D rigid2D;

        // Use this for initialization
        void Start ()
        {
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Run every physics iteration
        void FixedUpdate ()
        {
            float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

            Vector2 newPosition = rigid2D.position + Vector2.right * x;

            newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

            rigid2D.MovePosition(newPosition);
        }

        void OnCollisionEnter2D (Collision2D _col2D)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}