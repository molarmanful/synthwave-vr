using UnityEngine;

public class Texture_Scroll : MonoBehaviour {

  float scrollSpeed = 0.3529f;
  Renderer rend;

  void Start(){
    rend = GetComponent<Renderer>();
  }

  void Update(){
    float offset = Time.time * -scrollSpeed;
    rend.material.mainTextureOffset = new Vector2(0, offset);
  }
}
