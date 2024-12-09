//Повторить действия из урока:
//Вывести значения в консоль с типами данных int, float, bool
//Создать класс с нанесением урона через int и float на старте игры
//Создать метод, где будет вычисляться урон по формуле baseDamage * multiplier
//При вычислении урона выводим логи в консоль. Для это можно использовать составные строки

using System;
using UnityEngine;

namespace XomanyaCode
{
    public class HW_1 : MonoBehaviour
    {
        private void Start()
        {
            MyClass();
            Damage();
            publicDamage();
        }
        private void MyClass()
        {
            int a = 5;
            float b = 3.123f;
            bool c = true;
            
            Debug.LogError(a);
            Debug.LogError(b);
            Debug.LogError(c);
        }

        private void Damage()
        {
            float float_damage = 1.53f;
            int int_damage = 5;
            Debug.LogWarning($"Player damage {float_damage} float hp and {int_damage} int hp");
        }
        
        public int baseDamage;
        public int multiplier;

        private void publicDamage()
        {
            int FinalDamage = 0;
            FinalDamage = baseDamage * multiplier;
            Debug.LogError($"Your damage is {FinalDamage} hp");
        }
    }
}