// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
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
            uint? dwPacketNumber = null,
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
        public uint DwPacketNumber;

        [NativeName("Type", "XINPUT_GAMEPAD")]
        [NativeName("Type.Name", "XINPUT_GAMEPAD")]
        [NativeName("Name", "Gamepad")]
        public Gamepad Gamepad;
    }
}
