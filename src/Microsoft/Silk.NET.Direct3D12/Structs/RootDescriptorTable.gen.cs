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
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_TABLE")]
    public unsafe partial struct RootDescriptorTable
    {
        public RootDescriptorTable
        (
            uint? numDescriptorRanges = null,
            DescriptorRange* pDescriptorRanges = null
        ) : this()
        {
            if (numDescriptorRanges is not null)
            {
                NumDescriptorRanges = numDescriptorRanges.Value;
            }

            if (pDescriptorRanges is not null)
            {
                PDescriptorRanges = pDescriptorRanges;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescriptorRanges")]
        public uint NumDescriptorRanges;

        [NativeName("Type", "const D3D12_DESCRIPTOR_RANGE *")]
        [NativeName("Type.Name", "const D3D12_DESCRIPTOR_RANGE *")]
        [NativeName("Name", "pDescriptorRanges")]
        public DescriptorRange* PDescriptorRanges;
    }
}
