﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface IChooseManager
    {
        ISweepstakeManager MakeAManager(string sweepstakeType);
    }
}
