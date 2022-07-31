using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBlock : MonoBehaviour, IDamageable
{    
    public void ApplyDamage()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<ParticleSystem>().Play();
    }
}
