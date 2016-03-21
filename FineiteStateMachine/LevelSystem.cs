using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace ADGP_130
{
    class LevelingSystem
    {
         
        public LevelingSystem(int level)
        {
            int m_level = level;
            double m_exp = Math.Log10(m_level) * m_level; 
        }
    }
}
