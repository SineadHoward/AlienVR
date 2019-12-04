using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health = 10;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        //_animator.SetTrigger("get a hit (R)");
        if (Health <= 0)
        {
            return;
        }

        Health -= damage;
        if (Health <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        // _animator.SetTrigger("dead");.SetBool("levelFinished", true);
        _animator.SetBool("isDead", true);
    }
}