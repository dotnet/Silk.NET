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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVERTEXELEMENT9")]
    public unsafe partial struct Vertexelement9
    {
        public Vertexelement9
        (
            ushort? stream = null,
            ushort? offset = null,
            byte? type = null,
            byte? method = null,
            byte? usage = null,
            byte? usageIndex = null
        ) : this()
        {
            if (stream is not null)
            {
                Stream = stream.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (method is not null)
            {
                Method = method.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (usageIndex is not null)
            {
                UsageIndex = usageIndex.Value;
            }
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
