﻿using Newtonsoft.Json;

namespace EnergySmartBridge.WebService
{
    public class WaterHeaterOutput
    {
        public string Success { get; set; } = "0";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateRate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SetPoint { get; set; }
    }
}
