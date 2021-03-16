// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XInput
{
    [NativeName("Name", "_XINPUT_BATTERY_INFORMATION")]
    public unsafe partial struct BatteryInformation
    {
        public BatteryInformation
        (
            byte? batteryType = null,
            byte? batteryLevel = null
        ) : this()
        {
            if (batteryType is not null)
            {
                BatteryType = batteryType.Value;
            }

            if (batteryLevel is not null)
            {
                BatteryLevel = batteryLevel.Value;
            }
        }


        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "BatteryType")]
        public byte BatteryType;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "BatteryLevel")]
        public byte BatteryLevel;
    }
}
