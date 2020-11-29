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
    [NativeName("Name", "_XINPUT_CAPABILITIES")]
    public unsafe partial struct Capabilities
    {
        public Capabilities
        (
            byte? type = null,
            byte? subType = null,
            ushort? flags = null,
            Gamepad? gamepad = null,
            Vibration? vibration = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (subType is not null)
            {
                SubType = subType.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (gamepad is not null)
            {
                Gamepad = gamepad.Value;
            }

            if (vibration is not null)
            {
                Vibration = vibration.Value;
            }
        }


        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Type")]
        public byte Type;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "SubType")]
        public byte SubType;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "Flags")]
        public ushort Flags;

        [NativeName("Type", "XINPUT_GAMEPAD")]
        [NativeName("Type.Name", "XINPUT_GAMEPAD")]
        [NativeName("Name", "Gamepad")]
        public Gamepad Gamepad;

        [NativeName("Type", "XINPUT_VIBRATION")]
        [NativeName("Type.Name", "XINPUT_VIBRATION")]
        [NativeName("Name", "Vibration")]
        public Vibration Vibration;
    }
}
