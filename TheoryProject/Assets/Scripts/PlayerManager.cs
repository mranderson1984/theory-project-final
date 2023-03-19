using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed=40;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime* speed;
        Vector3 side = Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speed;
        playerRb.AddForce(forward, ForceMode.Impulse);
        playerRb.AddForce(side, ForceMode.Impulse);
    }
}
