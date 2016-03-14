using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Practice
{

    class FinistateStatMachine
    {
        Enum from;
        class Transition
        {
            public Transition(Enum _from, Enum _to)
            {

                
            }
        }
        Enum currentStats;

        List<Enum> stats;
        List<Enum> validTrans;

        /// <summary>
        /// Constructer for the FSM
        /// Takes in the first Enum 
        /// </summary>
        /// <param FininitStateMachine ="_initial"> Takes  in the first stat </para>
        public FinistateStatMachine(Enum _initial) 
        {
            stats = new List<Enum>();
            validTrans = new List<Enum>();
            currentStats = _initial;
        }
        public bool AddStat(Enum _stat)
        {
            // Makes sure that there is a stat before adding another transition
            if (!stats.Contains(_stat)) // List<>.Contains ~ Lets me know if the elements in the list(returning a bool)
            {
                stats.Add(_stat);
                return true;
            }
            else
            {
                Console.WriteLine("Cant do that");
                return false;
            }
        }
        // Informs use of what stat there transtioned at 
        public void StatInfo()
        {
            Console.WriteLine("Finite Stat Machine is comprised of...");
            int count = 0; // Records the ammount of stats that have been added the List<Enum>
            foreach (Enum s in stats)
            {
                Console.WriteLine("Stat " + count.ToString() + ": " + s.ToString());
                ++count;
            }
            Console.WriteLine("Current Stat(s) is: " + currentStats.ToString());
        }

        // Dictionary<(Key),(Whats to be sent through to be compared)>
        Dictionary<Enum, List<Transition>> transitionTable; 

        public bool AddTransiton(Enum _from, Enum _to)
        {
            Transition t = new Transition(_from, _to);
            if (transitionTable[_from].Contains(t))
            {
                //transitionTable.Add(to, );
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        class Program
        {
            // enumates the player states
            enum PlayerStats { init, idle, walk, run} 

            static void Main(string[] args)
            {

                Transition StandStill = new Transition(PlayerStats.idle, PlayerStats.idle);
                // Creates a a FinitSra
                FinistateStatMachine fsm = new FinistateStatMachine(PlayerStats.idle);

                fsm.AddStat(PlayerStats.init);
                fsm.AddStat(PlayerStats.idle);
                fsm.AddStat(PlayerStats.walk);
                fsm.AddStat(PlayerStats.run);
                fsm.AddStat(PlayerStats.init);
                




                fsm.StatInfo();
                Console.ReadKey();


            }
        }
    }
}
