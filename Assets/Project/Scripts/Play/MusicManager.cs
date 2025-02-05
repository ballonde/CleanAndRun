using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public ManagerManager mM;
    public AudioSource audioSource;

    public List<Music> musics;
    public Music selectedMusic;

    public float interval;

    // Awake is called before Start
    void Awake()
    {
        mM = FindObjectOfType<ManagerManager>();
        selectedMusic = musics[mM.selectedMusicIndex];
        audioSource.PlayOneShot(selectedMusic.music);

        interval = (60f / selectedMusic.bpm) * 2f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
