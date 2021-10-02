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
    [NativeName("Name", "D3D12_BUFFER_RTV")]
    public unsafe partial struct BufferRtv
    {
        public BufferRtv
        (
            ulong? firstElement = null,
            uint? numElements = null
        ) : this()
        {
            if (firstElement is not null)
            {
                FirstElement = firstElement.Value;
            }

            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "FirstElement")]
        public ulong FirstElement;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumElements")]
        public uint NumElements;
    }
}
