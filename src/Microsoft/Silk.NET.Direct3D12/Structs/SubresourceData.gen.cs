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
    [NativeName("Name", "D3D12_SUBRESOURCE_DATA")]
    public unsafe partial struct SubresourceData
    {
        public SubresourceData
        (
            void* pData = null,
            nint? rowPitch = null,
            nint? slicePitch = null
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


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pData")]
        public void* PData;

        [NativeName("Type", "LONG_PTR")]
        [NativeName("Type.Name", "LONG_PTR")]
        [NativeName("Name", "RowPitch")]
        public nint RowPitch;

        [NativeName("Type", "LONG_PTR")]
        [NativeName("Type.Name", "LONG_PTR")]
        [NativeName("Name", "SlicePitch")]
        public nint SlicePitch;
    }
}
