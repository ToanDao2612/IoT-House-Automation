﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.House.Automation.Microservices.Arduino.Api.ViewModel
{
    public class EventTriggerViewModel
    {
        [Required]
        [RegularExpression("^[0-9a-f]{8}-[0-9a-f]{4}-[0-5][0-9a-f]{3}-[089ab][0-9a-f]{3}-[0-9a-f]{12}$")]
        public string ArduinoIdentifier { get; set; }
        [Required]
        public string EventTargetName { get; set; }
        [Required]
        public object EventTargetValue { get; set; }
    }
}
