using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float HP = 50;
    public GameObject bot = null;
   // public RagdollScript ragdollScript;

    public void AddDamage(float damage)
    {
        HP -= damage;
        if(HP <= 0)
        {
            //ragdollScript.DisablePhysics();
            gameObject.SetActive(false);
            bot.SetActive(false);
        }
    }
    public IEnumerator destroyer()
    {
        Destroy(bot);
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
        
    }
}
