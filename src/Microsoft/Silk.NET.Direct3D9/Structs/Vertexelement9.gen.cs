// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVERTEXELEMENT9")]
    public unsafe partial struct Vertexelement9
    {
        public Vertexelement9
        (
            ushort stream = default,
            ushort offset = default,
            byte type = default,
            byte method = default,
            byte usage = default,
            byte usageIndex = default
        )
        {
            Stream = stream;
            Offset = offset;
            Type = type;
            Method = method;
            Usage = usage;
            UsageIndex = usageIndex;
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "Stream")]
        public ushort Stream;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "Offset")]
        public ushort Offset;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Type")]
        public byte Type;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Method")]
        public byte Method;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Usage")]
        public byte Usage;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "UsageIndex")]
        public byte UsageIndex;
    }
}
