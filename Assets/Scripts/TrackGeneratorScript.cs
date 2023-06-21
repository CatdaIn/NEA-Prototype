using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGeneratorScript : MonoBehaviour
{
    private int trackSize;
    private int[] startPos;
    private Graph track;

    public TrackGeneratorScript(){
        trackSize = 7;
        track = new Graph(trackSize);
        startPos = new int[]{1, trackSize / 2};
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
