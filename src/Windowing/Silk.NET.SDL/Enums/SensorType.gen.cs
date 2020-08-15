// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_sensor_L69_C9")]
    [NativeName("Name", "SDL_SensorType")]
    public enum SensorType
    {
        [NativeName("Name", "SDL_SENSOR_INVALID")]
        SensorInvalid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_SENSOR_UNKNOWN")]
        SensorUnknown = 0x0,
        [NativeName("Name", "SDL_SENSOR_ACCEL")]
        SensorAccel = 0x1,
        [NativeName("Name", "SDL_SENSOR_GYRO")]
        SensorGyro = 0x2,
    }
}
