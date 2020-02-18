using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

  public float degrees = 1f;
  GameObject system;

  void Start() {
    system = GameObject.Find("System");
  }

  void Update() {
    transform.RotateAround(system.transform.position, Vector3.up, degrees * Time.deltaTime);
  }
}
