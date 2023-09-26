using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemy;

    public Target Target => _target;
    public Enemy Enemy => _enemy;

}
