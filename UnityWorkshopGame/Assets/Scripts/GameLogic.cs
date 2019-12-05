using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Text _uiDeathText;
    public Text _uiScoreText;

    public static GameLogic Instance { get; set; }

    bool _playerAlive = true;
    public bool PlayerAlive { get { return _playerAlive; } }

    float _score = 0;

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;
    }

    void Update()
    {
        // Slightly dodgy way to update score - make dependant on game time
        if (_playerAlive)
        {
            _score += Time.deltaTime * 100f;
            _uiScoreText.text = $"Score: {(int)_score}";
        }
    }

    public void ObstacleGotHit()
    {
        _playerAlive = false;

        if (_uiDeathText)
        {
            _uiDeathText.enabled = true;
        }
    }
}
