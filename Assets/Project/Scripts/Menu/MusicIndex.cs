using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicIndex : MonoBehaviour
{
    public ManagerManager mM;
    public int index;

    public void SelectIndex()
    {
        mM.selectedMusicIndex = index;
        SceneManager.LoadScene("PlayingScene");
    }
}
