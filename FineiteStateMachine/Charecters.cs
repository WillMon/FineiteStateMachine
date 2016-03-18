using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineiteStateMachine
{

    interface ICommonChrStats
    {

        string _chrID { get; set; } 
        float _attMultyPlyer { get; set; }
        int _health { get; set; }
        int _statmina { get; set; }


        int TakeDmg();
        int DealDmg();


    }
    static class Charecters
    {
        class Sentanel: ICommonChrStats
        {
            public string _chrID { get; set; }
            public float _attMultyPlyer { get; set; }
            public int _heath { get; set; }
            public int _stamina { get; set; }

            public Sentanel(int health, int stamina)
            {
                _chrID = "Snow";
                _attMultyPlyer = .5f;
                _heath = health;
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
