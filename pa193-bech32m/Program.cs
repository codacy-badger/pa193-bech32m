﻿using System;
using pa193_bech32m.CLI;

namespace pa193_bech32m
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var cli = new Cli(Console.Out);
            cli.Run(args);
        }
    }
}
