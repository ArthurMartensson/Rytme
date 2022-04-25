using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avsender : MonoBehaviour
{
    public GameObject kule;
    public Treff treff;
    // Update is called once per frame
    public void Send()
    {
        GameObject k = Instantiate(kule, transform);
        treff.kuler.Add(k.transform);
    }
}
