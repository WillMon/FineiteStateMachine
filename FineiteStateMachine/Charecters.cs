using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_130
{
    static class Charecters
    {
        
        enum IChrClasses { MAGE, SENTINAL, WARRIOR }

    interface ICommonChrStat
    {
        float _attMultyPlyer { get; set; }
        int _health { get; set; }
        int _stamina { get; set; }


        void TakeDmg();
        void DealDmg();


    }
    
       
        class Mage : ICommonChrStat
        {
            string _chrClass { get; set; }
            string _chrID { get; set; }
            public float _attMultyPlyer { get; set; }
            public int _health { get; set; }
            public int _stamina { get; set; }

            public Mage(int health, int stamina)
            {
                _chrClass = "Mage";
                _chrID = "Yuffy";
                _attMultyPlyer = .5f;
                _health = health;
                _stamina = stamina;
            }

            public void TakeDmg()
            {

            }
  
            public void DealDmg()
            {

            }

        }
        class Sentanel : ICommonChrStat
        {
            string _chrClass { get; set; }
            string _chrID { get; set; }
            public float _attMultyPlyer { get; set; }
            public int _health { get; set; }
            public int _stamina { get; set; }

            public Sentanel(int health, int stamina)
            {
                _chrClass = "Sentanel";
                _chrID = "Snow";
                _attMultyPlyer = .5f;
                _health = health;
                _stamina = stamina;

            }

            public void TakeDmg()
            {

            }

            public void DealDmg()
            {

            }
        }
        class Warrior : ICommonChrStat
        {
            string _chrClass { get; set; }
            string _chrID { get; set; }
            public float _attMultyPlyer { get; set; }
            public int _health { get; set; }
            public int _stamina { get; set; }

            public Warrior(int health, int stamina)
            {
                _chrClass = "Warrior";
                _chrID = "Cloud";
                _attMultyPlyer = .5f;
                _health = health;
                _stamina = stamina;

            }

            public void TakeDmg()
            {

            }

            public void DealDmg()
            {

            }
        }
    }
}