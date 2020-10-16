using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CoinScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(eulers: new Vector3(x: 15f, y: 2f, z: 92f) * Time.deltaTime);
    }
}
