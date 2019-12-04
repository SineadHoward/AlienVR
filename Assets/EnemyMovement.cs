using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _nav;
    private Transform _player;
    private EnemyHealth _enemyHealth;
    //private Animator _animator;

    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _enemyHealth = GetComponent<EnemyHealth>();
       // _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (_enemyHealth.Health > 0)
        {
           // System.Diagnostics.Debug.WriteLine("follow ");
            _nav.SetDestination(_player.position);
        }
        else
        {
            _nav.enabled = false;
            //_animator.SetBool("levelFinished", true);
        }
    }
}
