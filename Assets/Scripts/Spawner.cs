using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform _target;

    public void Work()
    {
        Instantiate(_template, transform.position, Quaternion.identity);
    }

    private void Start()
    {
        _template.SetTarget(_target);
    }
}
