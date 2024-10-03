using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPosition : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("The position of " + gameObject.tag + " is " + transform.position);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
