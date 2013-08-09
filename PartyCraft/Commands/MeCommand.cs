﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Craft.Net.Common;
using Craft.Net.Server;

namespace PartyCraft.Commands
{
    public class MeCommand : Command
    {
        public override string DefaultCommand
        {
            get { return "me"; }
        }

        public override string Documentation
        {
            get
            {
                return "Allows you to speak in third person.\n" +
                    "Usage: /me " + ChatColors.Italic + "text\n" +
                    "Example: /me mines a block";
            }
        }

        public override void Execute(Server server, RemoteClient user, string userText, params string[] parameters)
        {
            server.MinecraftServer.SendChat(string.Format(server.SettingsProvider.Get<string>("chat.self.format"),
                user.Username, userText));
        }
    }
}
