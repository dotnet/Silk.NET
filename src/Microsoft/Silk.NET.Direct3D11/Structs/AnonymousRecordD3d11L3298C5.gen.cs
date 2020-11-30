// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L3298_C5")]
    public unsafe partial struct AnonymousRecordD3d11L3298C5
    {
        public AnonymousRecordD3d11L3298C5
        (
            uint? numElements = null,
            uint? elementWidth = null
        ) : this()
        {
            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }

            if (elementWidth is not null)
            {
                ElementWidth = elementWidth.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumElements")]
        public uint NumElements;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ElementWidth")]
        public uint ElementWidth;
    }
}
