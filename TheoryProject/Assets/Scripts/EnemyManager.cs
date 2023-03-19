using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    public float speed = 20;
    protected Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    virtual protected void Move()
    {
        Vector3 playerDirection = (player.transform.position - gameObject.transform.position).normalized;
        enemyRb.AddForce(playerDirection * speed * Time.deltaTime, ForceMode.Impulse);
    }

}
