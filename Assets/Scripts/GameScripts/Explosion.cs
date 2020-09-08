using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public MainScript Main;

    public bool ExplosionReady { get; set; }
    public bool ExplosionWas { get; set; }
    public int BombCount { get; set; }

    public GameObject ExplosionPhysic; // GameObject create Explosion

    void Start()
    {
        ExplosionReady = false;
        ExplosionWas = false;
        ExplosionPhysic.gameObject.SetActive(false);
    }

    IEnumerator BombWait()
    {
        yield return new WaitForSeconds(0.15f);
        BombCount++;
        ExplosionPhysic.SetActive(false);
        ExplosionWas = false;
    }

    public void AndNowMakeBoom()
    {
        if (ExplosionWas == false)
        {
            ExplosionPhysic.SetActive(true);
            ExplosionWas = true;
            StartCoroutine(BombWait());
        }
    }
}
