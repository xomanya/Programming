// Повторить действия из уроков:
// Добавить условие смерти для персонажа: У персонажа есть int hp и bool isDeath.
// Когда кол-во жизней уменьшается до 0, то isDeath становится true.
// Доп. задание: hp не могут опуститься ниже 0.
// Написать логику для определения противника/союзника на старте игры
// У вас есть персонаж, который имеет изначально серый цвет
// Если персонаж это противник, цвет меняется на красный
// Если персонаж это союзник, цвет меняется на синий.
// В инспекторе через bool отображается, что это противник/союзник
// Поменять цвет можно через компонент MeshRenderer

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class HW_2 : MonoBehaviour
{
    public int hp;
    private bool isDeath;
    public bool enemy;
    void Start()
    {
        isDeath = false;
        if (hp < 0)
        {
            Debug.LogWarning($"I'm not sure it's possible, change your hp");
        }
        else
        {
            Death();
        }
        if (enemy == true)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
    
    void Death()
    {
        if (hp == 0)
        {
            isDeath = true;
        }
        else if (hp > 0)
        {
            isDeath = false;
        }
        Debug.LogError($"Am I dead? {isDeath}, hp = {hp}");
    }
}