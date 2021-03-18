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
    [NativeName("Name", "_XINPUT_GAMEPAD")]
    public unsafe partial struct Gamepad
    {
        public Gamepad
        (
            ushort? wButtons = null,
            byte? bLeftTrigger = null,
            byte? bRightTrigger = null,
            short? sThumbLX = null,
            short? sThumbLY = null,
            short? sThumbRX = null,
            short? sThumbRY = null
        ) : this()
        {
            if (wButtons is not null)
            {
                WButtons = wButtons.Value;
            }

            if (bLeftTrigger is not null)
            {
                BLeftTrigger = bLeftTrigger.Value;
            }

            if (bRightTrigger is not null)
            {
                BRightTrigger = bRightTrigger.Value;
            }

            if (sThumbLX is not null)
            {
                SThumbLX = sThumbLX.Value;
            }

            if (sThumbLY is not null)
            {
                SThumbLY = sThumbLY.Value;
            }

            if (sThumbRX is not null)
            {
                SThumbRX = sThumbRX.Value;
            }

            if (sThumbRY is not null)
            {
                SThumbRY = sThumbRY.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wButtons")]
        public ushort WButtons;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bLeftTrigger")]
        public byte BLeftTrigger;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bRightTrigger")]
        public byte BRightTrigger;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "sThumbLX")]
        public short SThumbLX;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "sThumbLY")]
        public short SThumbLY;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "sThumbRX")]
        public short SThumbRX;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "sThumbRY")]
        public short SThumbRY;
    }
}
