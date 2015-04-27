using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public interface IVacuumCleaner: IWhiteGoods
    {
        TypeCleaner TypeCleaner { get; }
        TypeDustCollector TypeDustCollector { get; }
        int Power { get; }
    }
}
