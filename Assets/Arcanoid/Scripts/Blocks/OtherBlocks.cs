using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBlocks : BaseBlock
{

    [SerializeField] private ParticleSystem particle = null;

    private void Start()
    {
        particle = Instantiate(particle, gameObject.transform.position, Quaternion.identity);
        particle.transform.SetParent(gameObject.transform);
    }

    //add collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        particle.Simulate(0f, true, true);
        particle.transform.position = collision.contacts[0].point;
        particle.Play();
    }
}
