using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public static GameLogic Instance { get; set; }

    bool _playerAlive = true;
    public bool PlayerAlive { get { return _playerAlive; } }

    void Awake () {
        Debug.Assert(Instance == null);
        Instance = this;
	}
	
    public void ObstacleGotHit()
    {
        _playerAlive = false;
    }
}
