using System;
using Newtonsoft.Json.Linq;
using Optional;
using Util;

namespace Data
{
    public class DeviceData
    {
        public static Option<JObject, ErrorString> Create(JObject data)
        {
            if(data["DeviceId"] == null) 
            {
                return Option.None<JObject, ErrorString>("Missing 'DeviceId' property.");
            }

            if(data["DeviceName"] == null) 
            {
                return Option.None<JObject, ErrorString>("Missing 'DeviceName' property.");
            }

            return data.Some<JObject, ErrorString>();
        }
    }
}