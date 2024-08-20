using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class formatted
{
    [JsonProperty("international")]
    public string international { get; set; }

    [JsonProperty("national")]
    public string national { get; set; }

    [JsonProperty("rfc")]
    public string rfc { get; set; }

    [JsonProperty("e164")]
    public string e164 { get; set; }

}

public class data
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("detectedCountry")]
    public string detectedCountry { get; set; }

    [JsonProperty("countrycode")]
    public int countrycode { get; set; }

    [JsonProperty("numberNational")]
    public int numberNational { get; set; }

    [JsonProperty("extension")]
    public object extension { get; set; }

    [JsonProperty("isvalid")]
    public bool isvalid { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("formatted")]
    public formatted formatted { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
