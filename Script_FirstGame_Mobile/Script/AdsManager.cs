using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    private string gameId = "4589157";

    bool testMode = true;
    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }



  
}
