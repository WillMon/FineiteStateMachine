using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Practice
{

    class FinistateStatMachine
    {
        
        public class Transition 
        {
            public Enum from, to;
            public Transition(Enum _from, Enum _to)
            {
                from = _from;
                to = _to;
                
            }
        }
        
        public Enum currentStates;
        public Dictionary<Enum, List<Transition>> transitionTable;
        List<Enum> States;

        //List<Enum> validTrans;

        /// <summary>
        /// Constructer for the FSM
        /// Takes in the first Enum 
        /// </summary>
        /// <param FininitStateMachine ="_initial"> Takes  in the first stat </para>
        public FinistateStatMachine(Enum _initial) 
        {
            States = new List<Enum>();
            //validTrans = new List<Enum>();
            transitionTable = new Dictionary<Enum, List<Transition>>();
            currentStates = _initial;
        }
        public bool AddStat(Enum _stat)
        {
            // Makes sure that there is a stat before adding another transition
            if (!States.Contains(_stat)) // List<>.Contains ~ Lets me know if the elements in the list(returning a bool)
            {
                States.Add(_stat);
                
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
            int count = 0; // Records the ammount of States that have been added the List<Enum>
            foreach (Enum s in States)
            {
                Console.WriteLine("Stat " + count.ToString() + ": " + s.ToString());
                ++count;
            }
            Console.WriteLine("Current Stat(s) is: " + currentStates.ToString());
        }

        // Dictionary<(Key),(Whats to be sent through to be compared)>; 

        public void AddTransiton(Enum _from, Enum _to)
        {
            Transition t = new Transition(_from, _to);
            if (transitionTable.ContainsKey(_from))
            {
                transitionTable[_from].Add(t);

            }
        }

        public void TransitionsFromStates(Enum _tran)
        {
            
                foreach(Transition t in transitionTable[currentStates])
                {
                    _tran.GetHashCode();
                    Console.WriteLine(t.from);
                }
                
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>

        class MyMain
        {
            // enumates the player states
            enum PlayerStates { init, idle, walk, run} 

            static void Main(string[] args)
            {

                // Creates a a FinitSra
                FinistateStatMachine fsm = new FinistateStatMachine(PlayerStates.idle);

                fsm.AddStat(PlayerStates.init);
                fsm.AddStat(PlayerStates.idle);
                fsm.AddStat(PlayerStates.walk);
                fsm.AddStat(PlayerStates.run);
                

                
                fsm.AddTransiton(PlayerStates.init,PlayerStates.idle);
                fsm.AddTransiton(PlayerStates.idle, PlayerStates.walk);
                fsm.AddTransiton(PlayerStates.walk, PlayerStates.run);
                fsm.AddTransiton(PlayerStates.run, PlayerStates.walk);
                fsm.AddTransiton(PlayerStates.run, PlayerStates.idle);

                //Console.Write(fsm.transitionTable[PlayerStates.init]);

                fsm.TransitionsFromStates(PlayerStates.idle);




                fsm.StatInfo();
                Console.ReadKey();


            }
        }
    }
}
