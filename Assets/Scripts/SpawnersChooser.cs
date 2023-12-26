using UnityEngine;

public class SpawnersChooser : MonoBehaviour
{
    [SerializeField] private float _spawnTime;

    private Spawner[] _generationPoints;
    private float _currentTime;

    private void Start()
    {
        _generationPoints = GetComponentsInChildren<Spawner>();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _spawnTime)
        {
            _currentTime = 0;
            Spawner current = _generationPoints[Random.Range(0, _generationPoints.Length)];
            current.Work();
        }
    }
}