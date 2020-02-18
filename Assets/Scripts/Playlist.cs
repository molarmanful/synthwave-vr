using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Playlist : MonoBehaviour {

  Object[] myMusic;
  LinkedList<string> blist = new LinkedList<string>();

  void Awake(){
    myMusic = Resources.LoadAll("Music", typeof(AudioClip));
    GetComponent<AudioSource>().clip = myMusic[0] as AudioClip;
  }

  void Start(){
    playRandomMusic();
  }

  void Update(){
    if (!GetComponent<AudioSource>().isPlaying || Input.GetMouseButtonDown(0))
      playRandomMusic();
  }

  void playRandomMusic(){
    Object[] filtered = myMusic.Where(a => !blist.Contains(a.name)).ToArray();
    AudioClip clip = filtered[Random.Range(0, filtered.Length)] as AudioClip;
    blacklist(clip.name);
    GetComponent<AudioSource>().clip = clip;
    GetComponent<AudioSource>().Play();
  }

  void blacklist(string name){
    blist.AddFirst(name);
    if (blist.Count > 5)
      blist.RemoveLast();
  }
}
