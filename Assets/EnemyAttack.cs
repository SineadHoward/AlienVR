using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    private Animator _animator;
    private GameObject _player;
    private bool _collidedWithPlayer;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            System.Diagnostics.Debug.WriteLine("enter trigger with _player ");
            _animator.SetBool("IsNearPlayer", true);
            _collidedWithPlayer = true;
            Attack();
        }
        print("enter trigger with _player");
    }

    void OnCollisionEnter(Collision other)
    {
        System.Diagnostics.Debug.WriteLine("enter collided with _player ");
        if (other.gameObject == _player)
        {
            _collidedWithPlayer = true;
            Attack();
        }
        print("enter collided with _player");
    }

    void OnCollisionExit(Collision other)
    {
        System.Diagnostics.Debug.WriteLine("exit collided with _player ");
        if (other.gameObject == _player)
        {
            _collidedWithPlayer = false;
        }
        print("exit collided with _player");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _player)
        {
            _animator.SetBool("IsNearPlayer", false);
        }
        print("exit trigger with _player");
    }

    void Attack()
    {
        if (_collidedWithPlayer)
        {
            System.Diagnostics.Debug.WriteLine("hit by enemy ");
            PlayerHealth health = _player.GetComponent<PlayerHealth>();
            System.Diagnostics.Debug.WriteLine("health = " + health.currentHealth);
            if (health != null)
            {
                health.TakeDamage(10);
            }
            print("player has been hit");
        }
    }
}