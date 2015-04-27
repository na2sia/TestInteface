using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public class VacuumCleaner:WhiteGoods, IVacuumCleaner
    {

        public TypeCleaner TypeCleaner { get; set; }

        public TypeDustCollector TypeDustCollector { get; set; }

        public int Power { get; set; }
    }
}
