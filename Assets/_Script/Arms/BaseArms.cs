using UnityEngine;
using System.Collections;

public class BaseArms : LifeCycle {

    public Transform FirePoint; // 

    public Texture2D HeadPhoto; //

    public AudioClip attackSound; // 

    public AudioClip dieSound; //

    public string PriorityAttack; 

    public string AttackType; 
    
    public int Population;  // Occupied population

    public int TrainingTime; //traning one arms spend TrainingTime Seconds;

    public int MoveSpeed;

    public int AttackSpeed;

    public float AttackDistance;

    public int NeedBarrackLevel; // need barrack level can training arms;

    public int PerDamage; // damage from per attack;




    /// <summary>
    /// Training Info
    /// </summary>
    public string TrainingResType;

    public int TrainingRes;
    
    public int UpgradeNeedLabLevel;

    public int UpgradeRes;
    
    public void Training()
    {
        
    }
}
