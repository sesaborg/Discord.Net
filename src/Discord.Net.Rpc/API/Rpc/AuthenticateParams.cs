﻿#pragma warning disable CS1591
using Discord.Serialization;

namespace Discord.API.Rpc
{
    internal class AuthenticateParams
    {
        [ModelProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
