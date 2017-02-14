using System;
using Optional;

namespace Data
{
    public class DeviceData
    {
        public static Option<dynamic, string> Create(dynamic data)
        {
            if(data.DeviceId == null) 
            {
                return Option.None<dynamic, string>("Missing 'DeviceId' property.");
            }

            if(data.DeviceName == null) 
            {
                return Option.None<dynamic, string>("Missing 'DeviceName' property.");
            }

            return data.Some<dynamic, Exception>();
        }
    }
}