using UnityEngine;

public class NozelMovement : MonoBehaviour
{
    //public Vector2 turn1;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //turn1.y += Input.GetAxis("Mouse Y");
        //transform.localRotation = Quaternion.Euler(-turn1.y, 0, 0 );

        if(Input.GetKeyDown(KeyCode.Space)){
            
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = bulletSpawnPoint.forward * bulletspeed;
        }
        
    }
}
