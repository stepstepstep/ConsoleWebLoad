﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ConsoleWebLoad.CommandParser;

namespace ConsoleWebLoad
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var CmdResult = CommandParser.CommandParser.Parse(args);
            CommandParser.CommandExecutor.Execute(CmdResult);

        }

    }
}
