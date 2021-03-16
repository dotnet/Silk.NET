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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MEMCPY_DEST")]
    public unsafe partial struct MemcpyDest
    {
        public MemcpyDest
        (
            void* pData = null,
            nuint? rowPitch = null,
            nuint? slicePitch = null
        ) : this()
        {
            if (pData is not null)
            {
                PData = pData;
            }

            if (rowPitch is not null)
            {
                RowPitch = rowPitch.Value;
            }

            if (slicePitch is not null)
            {
                SlicePitch = slicePitch.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pData")]
        public void* PData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "RowPitch")]
        public nuint RowPitch;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SlicePitch")]
        public nuint SlicePitch;
    }
}
