using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    //Common behaviour variables for different animals
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float animalHealth;
    //previously had giveUpTimer, moved to Enemy class

    public abstract void Activity();
  
}

public abstract class Enemy : AnimalBase //could have IDoDamage
{
    [SerializeField] protected float attackDamage;

    public abstract void TargetPlayer();
    //public abstract void Attack();
}