using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform _target;

    public void Work()
    {
        Enemy newEnemy = Instantiate(_template, transform.position, Quaternion.identity);
        newEnemy.SetTarget(_target);
    }
}
