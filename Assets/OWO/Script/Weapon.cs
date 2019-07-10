﻿using UnityEngine;
public class Weapon : MonoBehaviour
{
    public enum WeaponType
    {
        EmptyHands,
        Pistol,
        Rifle,
        Rocket
    }

    public WeaponType weaponType = WeaponType.Pistol;
    public int ammo = 0;
    public int damage = 0;
    public float rate;
    public float recoilForce;
    public Transform FirePoint;
    public GameObject Bullet;
    public ParticleSystem GunFire;
    public GameObject Spark;
}