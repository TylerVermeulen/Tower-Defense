using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]private int damage;
    [SerializeField]private int health;
    public int Health {
        get { return health; }
        set { health = value; }

    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

}
