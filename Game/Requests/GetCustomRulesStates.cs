﻿using EmuWarface.Core;
using EmuWarface.Xmpp;

namespace EmuWarface.Game.Requests
{
    public static class GetCustomRulesStates
    {

        [Query(IqType.Get, "get_custom_rules_states")]
        public static void GetCustomRulesStatesSerializer(Client client, Iq iq)
        {
            //TODO


        }
    }
}
