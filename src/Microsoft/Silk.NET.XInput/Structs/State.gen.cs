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
    [NativeName("Name", "_XINPUT_STATE")]
    public unsafe partial struct State
    {
        public State
        (
            int? dwPacketNumber = null,
            Gamepad? gamepad = null
        ) : this()
        {
            if (dwPacketNumber is not null)
            {
                DwPacketNumber = dwPacketNumber.Value;
            }

            if (gamepad is not null)
            {
                Gamepad = gamepad.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwPacketNumber")]
        public int DwPacketNumber;

        [NativeName("Type", "XINPUT_GAMEPAD")]
        [NativeName("Type.Name", "XINPUT_GAMEPAD")]
        [NativeName("Name", "Gamepad")]
        public Gamepad Gamepad;
    }
}
