using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Formatted data
    /// </summary>
    public class Formatted
    {
        [JsonProperty("international")]
        public string International { get; set; }

        [JsonProperty("national")]
        public string National { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }

        [JsonProperty("e164")]
        public string E164 { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("detectedCountry")]
        public string DetectedCountry { get; set; }

        [JsonProperty("countrycode")]
        public int Countrycode { get; set; }

        [JsonProperty("numberNational")]
        public int NumberNational { get; set; }

        [JsonProperty("extension")]
        public object Extension { get; set; }

        [JsonProperty("isvalid")]
        public bool Isvalid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("formatted")]
        public Formatted Formatted { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
