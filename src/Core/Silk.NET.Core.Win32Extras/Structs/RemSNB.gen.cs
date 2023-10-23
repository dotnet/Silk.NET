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

namespace Silk.NET.Core.Win32Extras
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagRemSNB")]
    public unsafe partial struct RemSNB
    {
        public RemSNB
        (
            uint? ulCntStr = null,
            uint? ulCntChar = null
        ) : this()
        {
            if (ulCntStr is not null)
            {
                UlCntStr = ulCntStr.Value;
            }

            if (ulCntChar is not null)
            {
                UlCntChar = ulCntChar.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ulCntStr")]
        public uint UlCntStr;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ulCntChar")]
        public uint UlCntChar;
        [NativeName("Type", "OLECHAR[1]")]
        [NativeName("Type.Name", "OLECHAR[1]")]
        [NativeName("Name", "rgString")]
        public fixed char RgString[1];
    }
}
