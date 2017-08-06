﻿#pragma warning disable CS1591
using System;
using Discord.Serialization;

namespace Discord.API
{
    internal class EmbedImage
    {
        [ModelProperty("url")]
        public string Url { get; set; }
        [ModelProperty("proxy_url")]
        public string ProxyUrl { get; set; }
        [ModelProperty("height")]
        public Optional<int> Height { get; set; }
        [ModelProperty("width")]
        public Optional<int> Width { get; set; }
    }
}
