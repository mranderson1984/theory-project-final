using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed=40;
    private bool isScoring;
    const string SCORING_TAG = "ScoreZone";
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void HandleScoring()
    {
        if (isScoring)
        {
            StartCoroutine(StartScoring());
        }
    }
    private IEnumerator StartScoring()
    {
        while (isScoring)
        {
            ScoreManager.Instance.Score -= 4;
            yield return new WaitForSeconds(1);
        }

    }
    private void Move()
    {
        Vector3 forward = Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * speed;
        Vector3 side = Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speed;
        playerRb.AddForce(forward, ForceMode.Impulse);
        playerRb.AddForce(side, ForceMode.Impulse);
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(SCORING_TAG))
        {
            isScoring = false;
        }
            

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(SCORING_TAG))
        {
            isScoring = true;
            HandleScoring();
        }
    }

}
