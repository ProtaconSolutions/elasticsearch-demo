using System;
using Newtonsoft.Json.Linq;
using Optional;
using Util;

namespace Data
{
    // TODO: Write this as real object, at this point just simple validator. This is because writing dynamic object isn't done by just adding few properties.
    public class DeviceData
    {
        public static Option<JObject, ErrorString> Create(JObject data)
        {
            if(data["DeviceId"] == null) 
                return Option.None<JObject, ErrorString>("Missing 'DeviceId' property.");

            if(data["DeviceName"] == null) 
                return Option.None<JObject, ErrorString>("Missing 'DeviceName' property.");

            if(data["TimeStamp"] == null)
                return Option.None<JObject, ErrorString>("Missing 'DeviceName' property.");

            var timeStampAsLong = long.Parse(data["TimeStamp"].ToString());
            data["TimeStamp"] = DateTimeOffset.FromUnixTimeMilliseconds(timeStampAsLong).ToString("o");

            return data.Some<JObject, ErrorString>();
        }
    }
}