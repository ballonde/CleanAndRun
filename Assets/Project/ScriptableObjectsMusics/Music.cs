using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Music : ScriptableObject
{
    public AudioClip music;
    public float bpm;
    public float startSpeed;
    public float endSpeed;
}
