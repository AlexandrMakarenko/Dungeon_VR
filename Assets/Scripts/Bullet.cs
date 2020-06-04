using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10;
    public string[] targetTags = { "Enemy1", "Enemy2" };

    private void OnTriggerEnter(Collider enemy)
    {
        foreach(string currentTag in targetTags)
        {
            //если при попадании пули в цель тег совпадает с тегом врага, то цели проходит урон, иначе уничтожаем патрон
            if(currentTag == enemy.transform.tag)
            {
                //enemy.transform.GetComponent<EnemyHealth>().AddDamage(damage);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        Destroy(gameObject);
    }
}
