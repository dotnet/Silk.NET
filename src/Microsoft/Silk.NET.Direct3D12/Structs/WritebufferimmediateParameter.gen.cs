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
    [NativeName("Name", "D3D12_WRITEBUFFERIMMEDIATE_PARAMETER")]
    public unsafe partial struct WritebufferimmediateParameter
    {
        public WritebufferimmediateParameter
        (
            ulong? dest = null,
            uint? value = null
        ) : this()
        {
            if (dest is not null)
            {
                Dest = dest.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "Dest")]
        public ulong Dest;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Value")]
        public uint Value;
    }
}
