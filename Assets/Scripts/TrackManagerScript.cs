using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManagerScript : MonoBehaviour
{
    public GameObject trackPiece;
    public int trackSize = 7;
    public float trackPieceSize = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateTrack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateTrack(){
        for (int i = 0; i < trackSize; i++){
            for (int j = 0; j < trackSize; j++){
                Instantiate(trackPiece, new Vector3(trackPieceSize * i - (trackSize / 2) * trackPieceSize, trackPieceSize * j - (trackSize / 2) * trackPieceSize, 0), new Quaternion());
            }
        }
    }
}
