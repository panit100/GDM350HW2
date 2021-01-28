using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace playerDLL
{
    public class PlayerController : MonoBehaviour
    {
        public void Setting(string name, int health)
        {
            PlayerInfomation.Name = name;
            PlayerInfomation.Health = health;
            PlayerInfomation.Maxhealth = health;
        }

        public void Hit(int damage)
        {
            if(PlayerInfomation.Health - damage <= 0)
            {
                PlayerInfomation.Health = 0;
            }else PlayerInfomation.Health -= damage;
        }

        public void Heal(int heal)
        {
            if(PlayerInfomation.Health + heal >= PlayerInfomation.Maxhealth)
            {
                PlayerInfomation.Health = PlayerInfomation.Maxhealth;
            }else PlayerInfomation.Health += heal;
           
        }
    }
}
