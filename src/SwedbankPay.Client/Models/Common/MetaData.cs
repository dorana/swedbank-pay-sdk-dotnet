﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwedbankPay.Client.Models.Common
{
    public class MetaData : IdLink
    {
        //private Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        //public object this[string key]
        //{
        //    get => _dictionary.TryGetValue(key, out object value) ? value : null;
        //    set => _dictionary[key] = value;
        //}
        [JsonProperty("metadata")]
        public Dictionary<string,object> 
            Dict { get; set; }

    }
}