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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "_XINPUT_KEYSTROKE")]
    public unsafe partial struct Keystroke
    {
        public Keystroke
        (
            ushort? virtualKey = null,
            char? unicode = null,
            ushort? flags = null,
            byte? userIndex = null,
            byte? hidCode = null
        ) : this()
        {
            if (virtualKey is not null)
            {
                VirtualKey = virtualKey.Value;
            }

            if (unicode is not null)
            {
                Unicode = unicode.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (userIndex is not null)
            {
                UserIndex = userIndex.Value;
            }

            if (hidCode is not null)
            {
                HidCode = hidCode.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "VirtualKey")]
        public ushort VirtualKey;

        [NativeName("Type", "WCHAR")]
        [NativeName("Type.Name", "WCHAR")]
        [NativeName("Name", "Unicode")]
        public char Unicode;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "Flags")]
        public ushort Flags;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "UserIndex")]
        public byte UserIndex;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "HidCode")]
        public byte HidCode;
    }
}
