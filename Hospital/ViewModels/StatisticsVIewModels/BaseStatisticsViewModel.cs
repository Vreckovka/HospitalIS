﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModels.StatisticsVIewModels
{
    public abstract class BaseStatisticsViewModel : BaseViewModel
    {
        public abstract void CalculateStatistics();
    }
}
