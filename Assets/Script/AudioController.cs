using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource win;
    AudioSource main;
    public GameObject maincam;
    public GameObject panelSelesai;
    // Start is called before the first frame update
    void Start()
    {
        main = maincam.GetComponent<AudioSource>();
        win = win.GetComponent<AudioSource>();
        main.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(panelSelesai.activeSelf && main.isPlaying){
            main.Stop();
            win.Play();
        }
        if(!panelSelesai.activeSelf){
            win.Stop();
        }
    }
}
