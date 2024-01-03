using UnityEngine;

public class SpawnersChooser : MonoBehaviour
{
    [SerializeField] private float _spawnTime;

    private Spawner[] _spawners;
    private float _currentTime;

    private void Awake()
    {
        _spawners = GetComponentsInChildren<Spawner>();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTime)
        {
            _currentTime = 0;
            Spawner current = _spawners[Random.Range(0, _spawners.Length)];
            current.Work();
        }
    }
}