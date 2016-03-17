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
        /// </summary>  
        ///       /// Takes in the first Enum 
        /// <param FininitStateMachine ="intial"> Takes  in the first stat </para>
        public FinistateStatMachine(Enum intial)
        {
            m_States = new List<Enum>();
            //validTrans = new List<Enum>();
            _transtionTable = new Dictionary<Enum, List<Transition>>();
            _currentStates = intial;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AddStat(Enum state)
        {
            
            if (!m_States.Contains(state)) { // List<>.Contains ~ Lets me know if the elements in the list(returning a bool)
                m_States.Add(state);
                _transtionTable.Add(state, new List<Transition>());
                return false;
            }
            else {
                return true;
            }
        }

        /// <summary>
        ///  Prints States Stat To console
        /// </summary>
        /// <StatesInfor()>
        /// Prints out the listed sort of Enums and its enumaration 
        /// Prints out the conditions of the transitions 
        /// </StatesInfor>
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

        /// <summary>
        /// Qeues in the set of transitions
        /// </summary>
        /// <AddTransition(Enum from, Enum to)>
        /// AddTRansition takes in two arguments 
        /// thsi 
        /// </AddTransition>
        public bool AddTransiton(Enum from, Enum to)
        {

            Transition _t = new Transition(from, to);

            if (_transtionTable.ContainsKey(from))
            {
                _transtionTable[_currentStates].Add(_t);
                return true;
            }
            return false;
        }

        /// <summary> 
        /// Makes the Transion from the queued states
        /// </summary>
        /// <TranstitionFromStates(Enum trans)>
        /// This Sets  my States and makes sure of there possibale transitions 
        /// TrnsitonFromStates takes in one argument 
        /// A new Tempuary Transition<Object>(temp_Trans) is created 
        /// 
        /// A new Tempuary Dictanery<Enum,List<Transition<Object>>(temp_Dictionary) is created 
        /// Creats a Temporary Dictionary<Enum, List<TRanstion>>
        /// 
        /// if _currentStates value returns a (0) there at there init state
        /// transtion from that enumarate value can transiton to the next state. 
        /// no transtions can happen over that value or transition to that same value 
        /// 
        /// if _currentStates enumarte value retuns a (1) there at the next state 
        /// From this state the user can transition to thhe next transition 
        /// They can not transition over from that state or revert over to the init stat
        /// 
        /// if _currentStates value returns any other value pass the _currentState value of (1) 
        /// Transition to and fom that state can happen 
        /// Transitions form that state to the _currnetState (0) can not happen 
        /// </TranstitionFromStates>
        public void TransitionsFromStates()
        {


            foreach (Enum e in _transtionTable.Keys)
            {
                Transition temp_Trans = new Transition(_currentStates, e);
                if (AddTransiton(_currentStates, e))
                {
                    if (AddStat(e))
                    {
                        switch (_currentStates.GetHashCode())
                        {
                            case 0:
                                if (e.GetHashCode() > 1 || e.GetHashCode() == _currentStates.GetHashCode())
                                    Console.WriteLine(_currentStates + " can not make this transition to " + e);
                                else
                                {
                                    Console.WriteLine(_currentStates + " -> " + e);
                                    _transtionTable[_currentStates].Add(temp_Trans);
                                    _currentStates = e;
                                }
                                break;

                            case 1:
                                if (e.GetHashCode() <= 0 || (1 + _currentStates.GetHashCode()) < e.GetHashCode() 
                                    || e.GetHashCode() == _currentStates.GetHashCode())
                                    Console.WriteLine(_currentStates + " can not make this transtion to " + e);
                                else
                                {
                                    Console.WriteLine(_currentStates + " -> " + e);
                                    _transtionTable[e].Add(temp_Trans);
                                    _currentStates = e;
                                }
                                break;
                            default:
                                if (e.GetHashCode() <= 0 || e.GetHashCode() == _currentStates.GetHashCode())
                                    Console.WriteLine(_currentStates + " can not make this transtion to " + e);
                                else
                                {
                                    Console.WriteLine(_currentStates + " -> " + e);
                                    _transtionTable[e].Add(temp_Trans);
                                    _currentStates = e;
                                }
                                break;
                                
                        }
                        
                    }
                   
                    else { Console.WriteLine("Cant transition to a none exiatent state "); break; }
                }
                else { Console.WriteLine("No States have been added "); break; }
            }
        }
    }
}       
                //Console.WriteLine(_transtionTable[e].GetEnumerator());
            
       
