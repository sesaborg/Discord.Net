﻿#pragma warning disable CS1591

using Discord.Serialization;

namespace Discord.Rpc
{
    public class UserVoiceProperties
    {
        [ModelProperty("userId")]
        internal ulong UserId { get; set; }
        [ModelProperty("pan")]
        public Optional<Pan> Pan { get; set; }
        [ModelProperty("volume")]
        public Optional<int> Volume { get; set; }
        [ModelProperty("mute")]
        public Optional<bool> Mute { get; set; }
    }
}
