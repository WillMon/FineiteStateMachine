using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Practice
{

    class FinistateStatMachine
    {
        // Sets transtions between my 
        public class Transition
        {
            public Enum _from, _to;
            public Transition(Enum from, Enum to)
            {
                _from = from;
                _to = to;

            }
        }

        public Enum _currentStates;
        public Dictionary<Enum, List<Transition>> _transtionTable;
        List<Enum> m_States;

        //List<Enum> validTrans;

        /// <summary>
        /// Constructer for the FSM
        /// Takes in the first Enum 
        /// </summary>
        /// <param FininitStateMachine ="intial"> Takes  in the first stat </para>
        public FinistateStatMachine(Enum intial)
        {
            m_States = new List<Enum>();
            //validTrans = new List<Enum>();
            _transtionTable = new Dictionary<Enum, List<Transition>>();
            _currentStates = intial;
        }
        public bool AddStat(Enum state)
        {
            // Makes sure that there is a stat before adding another transition
            if (!m_States.Contains(state)) // List<>.Contains ~ Lets me know if the elements in the list(returning a bool)
            {
                m_States.Add(state);
                _transtionTable.Add(state, new List<Transition>());
                return true;
            }
            else
            {
                Console.WriteLine("Cant do that");
                return false;
            }
        }
        /// <summary>
        /// Informs use of what stat there transtioned at 
        /// </summary>

        public void StatInfo()
        {
            Console.WriteLine("Finite Stat Machine is comprised of...");
            int count = 0; // Records the ammount of States that have been added the List<Enum>
            foreach (Enum s in m_States)
            {
                Console.WriteLine("Stat " + count + ": " + s.ToString());
                ++count;

            }
            Console.WriteLine("Current Stat(s) is: " + _currentStates.ToString());

        }

        // Dictionary<(Key),(Whats to be sent through to be compared)>; 

        public void AddTransiton(Enum from, Enum to)
        {

            Transition _t = new Transition(from, to);

            if (_transtionTable.ContainsKey(from))
            {
                _transtionTable[from].Add(_t);
            }
        }
        /// <summary>
        /// This Sets  my States and makes sure of there possibale transitions 
        /// Creats a Temporary Dictionary<Enum, List<TRanstion>>
        /// 
        /// </summary>
        public void TransitionsFromStates(Enum trans)
        {
            Transition temp_Trans = new Transition(_currentStates, trans);
            Dictionary<Enum, List<Transition>> temp_Dictionary = new Dictionary<Enum, List<Transition>>();
            //foreach (Enum e in m_States)
            //{

            switch (_currentStates.GetHashCode())
            {
                case 0:
                    if (trans.GetHashCode() > 1 || trans.GetHashCode() == _currentStates.GetHashCode())
                        Console.WriteLine(_currentStates + " can not make this transition to " + trans);
                    else
                    {
                        Console.WriteLine(_currentStates + " -> " + trans);
                        //temp_Dictionary[e].Add(temp_Trans);
                        _currentStates = trans;
                    }
                    break;

                case 1:
                    if (trans.GetHashCode() <= 0 || (1 + _currentStates.GetHashCode()) < trans.GetHashCode() || trans.GetHashCode() == _currentStates.GetHashCode())
                        Console.WriteLine(_currentStates + " can not make this transtion to " + trans);
                    else
                    {
                        Console.WriteLine(_currentStates + " -> " + trans);
                        //temp_Dictionary[e].Add(temp_Trans);
                        _currentStates = trans;
                    }
                    break;
                default:
                    if (trans.GetHashCode() <= 0)
                        Console.WriteLine(_currentStates + " can not make this transtion to " + trans);
                    else
                    {
                        Console.WriteLine(_currentStates + " -> " + trans);
                        //temp_Dictionary[e].Add(temp_Trans);
                        _currentStates = trans;
                    }
                    break;
            }
        }
    }
}       
                
             
                //Console.WriteLine(_transtionTable[e].GetEnumerator());
            
       
