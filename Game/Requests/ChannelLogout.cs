﻿using EmuWarface.Core;
using EmuWarface.Xmpp;
using System;

namespace EmuWarface.Game.Requests
{
    public static class ChannelLogout
    {
        [Query(IqType.Get, "channel_logout")]
        public static void ChannelLogoutSerializer(Client client, Iq iq)
        {
            //TODO
            client.IqResult(iq);
        }
    }
}
