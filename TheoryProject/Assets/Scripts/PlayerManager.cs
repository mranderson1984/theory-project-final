using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed=50;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime;
        Vector3 side = Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime;
        playerRb.AddForce(forward, ForceMode.Impulse);
        playerRb.AddForce(side, ForceMode.Impulse);
    }
}
