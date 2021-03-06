﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IoT.House.Automation.Microservices.Arduino.Domain.Interfaces
{
    public interface IMap
    {
        IEnumerable<T> Map<T>(DataTable table) where T : new();
    }
}
