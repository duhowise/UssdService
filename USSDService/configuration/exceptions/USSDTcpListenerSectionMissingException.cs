﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exactmobile.ussdservice.exceptions 
{
    public class USSDTcpListenerSectionMissingException: Exception
    {
        public USSDTcpListenerSectionMissingException(String message) : base(message) { }
    }
}
