using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float forceMultiplier;
    private float _moveHorizontal;
    private float _moveVertical;

    


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _moveHorizontal = Input.GetAxis("Horizontal") * forceMultiplier;
        _moveVertical = Input.GetAxis("Vertical") * forceMultiplier;
        _rigidbody.AddForce(x: _moveHorizontal, y: 0, z: _moveVertical, ForceMode.Acceleration);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Cube"))
            GameObject.Destroy(other.gameObject);
    }
}