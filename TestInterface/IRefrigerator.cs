﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public interface IRefrigerator:IWhiteGoods
    {
        TypeControl TypeControl { get; }
        TypeDesign TypeDesign { get; }
    }
}
