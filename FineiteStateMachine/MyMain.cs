using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace ADGP_130
{
    class MyMain
    {
        // enumates the player states
        enum PlayerStates { init, idle, walk, run, att, picon }

        static void Main(string[] args)
        {

            // Creates a a FinitSra
            FinistateStatMachine fsm = new FinistateStatMachine(PlayerStates.run);

            fsm.AddStat(PlayerStates.init);
            fsm.AddStat(PlayerStates.idle);
            fsm.AddStat(PlayerStates.walk);
            fsm.AddStat(PlayerStates.run);



            fsm.AddTransiton(PlayerStates.init, PlayerStates.idle);
            fsm.AddTransiton(PlayerStates.idle, PlayerStates.walk);
            fsm.AddTransiton(PlayerStates.walk, PlayerStates.run);
            fsm.AddTransiton(PlayerStates.run, PlayerStates.walk);
            fsm.AddTransiton(PlayerStates.run, PlayerStates.idle);
            fsm.AddTransiton(PlayerStates.walk, PlayerStates.idle);


            fsm.StatInfo();


            fsm.ChangeState(PlayerStates.run);

            //var html = new System.Net.WebClient().DownloadString("");

            //Console.WriteLine(html.ToString());
            Console.ReadKey();


        }
    }
}
