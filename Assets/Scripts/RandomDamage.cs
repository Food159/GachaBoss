using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomDamage : MonoBehaviour
{
    public List<TextMeshPro> damg;
    public int[] damage = { 60, 20, 10, 9, 1 };
    public int total;
    public int randomNumber;
    private void Start()
    {
        foreach(var dmg in damage)
        {
            total += dmg;
        }
        randomNumber = Random.Range(0, total);

        for(int i = 0; i < damage.Length; i++)
        {
            if(randomNumber <= damage[i])
            {
                //damg[i].SetActive(true);
                return;
            }
            else
            {
                randomNumber -= damage[i];
            }
        }

        //foreach(var weight in damage)
        //{
        //    if(randomNumber <= weight)
        //    {
        //        Debug.Log("Award: " + weight);
        //    }
        //    else
        //    {
        //        randomNumber -= weight;
        //    }
        //}
    }
}
