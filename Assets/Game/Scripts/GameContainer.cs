using UnityEngine;

public class GameContainer : MonoBehaviour
{
    [SerializeField] private GameUpdates _gameUpdates;
    public GameUpdates GameUpdates => _gameUpdates;

    [SerializeField] private GameUIContainer _gameUIContainer;
    public GameUIContainer GameUIContainer => _gameUIContainer;

    private EnemyPoolView _enemyPoolView;
    public EnemyPoolView EnemyPoolView => _enemyPoolView;

    private void Awake()
    {
        _enemyPoolView = new EnemyPoolView();
        Game game = new Game(this);
    }
}
