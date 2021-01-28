using System;
using System.Collections.Generic;
using System.Text;

namespace playerDLL
{
    public static class PlayerInfomation
    {
        private static string name;
        private static int health;
        private static int maxhealth;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static int Health
        {
            get { return health; }
            set { health = value; }
        }
        public static int Maxhealth
        {
            get { return maxhealth; }
            set { maxhealth = value; }
        }
    }
}
