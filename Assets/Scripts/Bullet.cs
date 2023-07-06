using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbBullet;

    [SerializeField] float speedBullet;
    void Start()
    {
        rbBullet = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbBullet.velocity = transform.right * speedBullet;
        Destroy(gameObject, 5f);
    }
}
