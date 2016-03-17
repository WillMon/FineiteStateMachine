using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Practice
{
    class MyMain
    {
        // enumates the player states
        enum PlayerStates { init, idle, walk, run, att }

        static void Main(string[] args)
        {

            // Creates a a FinitSra
            FinistateStatMachine fsm = new FinistateStatMachine(PlayerStates.att);

            fsm.AddStat(PlayerStates.init);
            fsm.AddStat(PlayerStates.idle);
            fsm.AddStat(PlayerStates.walk);
            fsm.AddStat(PlayerStates.run);
            fsm.AddStat(PlayerStates.att);



            fsm.AddTransiton(PlayerStates.init, PlayerStates.idle);
            fsm.AddTransiton(PlayerStates.idle, PlayerStates.walk);
            fsm.AddTransiton(PlayerStates.walk, PlayerStates.run);
            fsm.AddTransiton(PlayerStates.run, PlayerStates.walk);
            fsm.AddTransiton(PlayerStates.run, PlayerStates.idle);
            fsm.AddTransiton(PlayerStates.walk, PlayerStates.idle);
            

            //Console.Write(fsm.transitionTable[PlayerStates.init]);


            fsm.StatInfo();


            fsm.TransitionsFromStates(PlayerStates.run);
            
            Console.ReadKey();


        }
    }
}
