using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }

        if (transform.rotation == Quaternion.identity)
        {
            transform.rotation = Quaternion.Euler(65f, 0f, 0f);
        }

        if (player != null)
        {
            offset = transform.position - player.transform.position;
        }
    }

    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
