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
    [NativeName("Name", "D3D12_DESCRIPTOR_RANGE1")]
    public unsafe partial struct DescriptorRange1
    {
        public DescriptorRange1
        (
            DescriptorRangeType? rangeType = null,
            uint? numDescriptors = null,
            uint? baseShaderRegister = null,
            uint? registerSpace = null,
            DescriptorRangeFlags? flags = null,
            uint? offsetInDescriptorsFromTableStart = null
        ) : this()
        {
            if (rangeType is not null)
            {
                RangeType = rangeType.Value;
            }

            if (numDescriptors is not null)
            {
                NumDescriptors = numDescriptors.Value;
            }

            if (baseShaderRegister is not null)
            {
                BaseShaderRegister = baseShaderRegister.Value;
            }

            if (registerSpace is not null)
            {
                RegisterSpace = registerSpace.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (offsetInDescriptorsFromTableStart is not null)
            {
                OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart.Value;
            }
        }


        [NativeName("Type", "D3D12_DESCRIPTOR_RANGE_TYPE")]
        [NativeName("Type.Name", "D3D12_DESCRIPTOR_RANGE_TYPE")]
        [NativeName("Name", "RangeType")]
        public DescriptorRangeType RangeType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescriptors")]
        public uint NumDescriptors;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BaseShaderRegister")]
        public uint BaseShaderRegister;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RegisterSpace")]
        public uint RegisterSpace;

        [NativeName("Type", "D3D12_DESCRIPTOR_RANGE_FLAGS")]
        [NativeName("Type.Name", "D3D12_DESCRIPTOR_RANGE_FLAGS")]
        [NativeName("Name", "Flags")]
        public DescriptorRangeFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OffsetInDescriptorsFromTableStart")]
        public uint OffsetInDescriptorsFromTableStart;
    }
}
