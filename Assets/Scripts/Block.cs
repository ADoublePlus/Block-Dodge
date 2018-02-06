using UnityEngine;

namespace BlockDodge
{
    public class Block : MonoBehaviour
    {

        // Use this for initialization
        void Start ()
        {
            GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
        }

        // Update is called once per frame
        void Update ()
        {
            if (transform.position.y < -2f)
            {
                Destroy(gameObject);
            }
        }
    }
}