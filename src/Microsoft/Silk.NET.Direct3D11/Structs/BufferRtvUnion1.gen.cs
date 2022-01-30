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

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L3857_C5")]
    public unsafe partial struct BufferRtvUnion1
    {
        public BufferRtvUnion1
        (
            uint? firstElement = null,
            uint? elementOffset = null
        ) : this()
        {
            if (firstElement is not null)
            {
                FirstElement = firstElement.Value;
            }

            if (elementOffset is not null)
            {
                ElementOffset = elementOffset.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstElement")]
        public uint FirstElement;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ElementOffset")]
        public uint ElementOffset;
    }
}
