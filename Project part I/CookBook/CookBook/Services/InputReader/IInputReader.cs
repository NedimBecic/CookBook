﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services.InputReader
{
    public interface IInputReader
    {
        ConsoleKeyInfo ReadKey(bool intercept);
    }
}
