using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public Animator animator;
    public bool enemyCollision = false;

    private void Awake()
    {
        Instance = this;
    }
    
    public void SetAnimation(string name)
    {
        animator.Play(name);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        enemyCollision = true;
    }
}