using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(menuName ="Settings/World")]
public class WordSettings : SingletonSettings<WordSettings>
{
    public int hpPlayer;

    public int nbBriqueTot;

    public int nbBriqueBrake;


    public void CheckGameOver()
    {
        if (hpPlayer < 0)
        {
            SceneManager.LoadScene(sceneName: "MenuLoose");
        }
    }


    public void CheckBrique()
    {
        brique[] br = FindObjectsOfType<brique>();
        nbBriqueTot = br.Length;
    }

    public void Awake()
    {
        
    }


}



