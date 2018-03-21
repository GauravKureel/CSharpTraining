﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingInterfaces
{
    public interface IEnableAirCondition
    {
        void IncreaseTemprature();
        void DecreaseTemprature();
        void SwitchOffAc();
    }
}
