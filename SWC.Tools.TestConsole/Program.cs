﻿using System.Linq;
using SWC.Tools.Common.Layout;
using SWC.Tools.Common.Networking;
using SWC.Tools.Common.Networking.Json.CommandArgs;
using SWC.Tools.Common.Configuration;
using System.IO;

namespace SWC.Tools.TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var data = File.ReadAllLines("cred.txt");
            var mgr = new MessageManager(ConfigKeys.AndroidServerUrl, data[0], data[1]);
        }
    }
}