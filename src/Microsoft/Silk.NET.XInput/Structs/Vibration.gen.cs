// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "_XINPUT_VIBRATION")]
    public unsafe partial struct Vibration
    {
        public Vibration
        (
            ushort? wLeftMotorSpeed = null,
            ushort? wRightMotorSpeed = null
        ) : this()
        {
            if (wLeftMotorSpeed is not null)
            {
                WLeftMotorSpeed = wLeftMotorSpeed.Value;
            }

            if (wRightMotorSpeed is not null)
            {
                WRightMotorSpeed = wRightMotorSpeed.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wLeftMotorSpeed")]
        public ushort WLeftMotorSpeed;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wRightMotorSpeed")]
        public ushort WRightMotorSpeed;
    }
}
