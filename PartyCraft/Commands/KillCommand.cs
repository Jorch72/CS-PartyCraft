﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Craft.Net.Server;

namespace PartyCraft.Commands
{
    public class KillCommand : Command
    {
        public override string DefaultCommand
        {
            get { return "kill"; }
        }

        public override string Documentation
        {
            get
            {
                return "Kills the user.\n" +
                       "Usage: /kill";
            }
        }

        public override void Execute(Server server, RemoteClient user, string text, params string[] parameters)
        {
            //user.Entity.LastDamageType = DamageType.Suicide; // TODO
            user.Entity.Health = 0;
        }
    }
}
