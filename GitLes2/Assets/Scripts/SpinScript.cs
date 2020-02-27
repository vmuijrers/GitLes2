using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    #region Serialized
    [SerializeField]
    [Range(-5.0f, 5.0f)]
    float spinSpeed = 1.0f;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+spinSpeed, transform.rotation.eulerAngles.z + spinSpeed);
    }
}
