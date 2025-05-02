using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3( 0f, 1.26f, -4.49f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
