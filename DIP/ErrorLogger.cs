﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class ErrorLogger : NewErrorLogger
    {
        public void Log(string errorMessage)
        {
            newLogger(errorMessage);
        }

        public void newLogger(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
