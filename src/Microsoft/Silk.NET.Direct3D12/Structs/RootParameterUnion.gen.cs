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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3965_C5")]
    public unsafe partial struct RootParameterUnion
    {
        public RootParameterUnion
        (
            RootDescriptorTable? descriptorTable = null,
            RootConstants? constants = null,
            RootDescriptor? descriptor = null
        ) : this()
        {
            if (descriptorTable is not null)
            {
                DescriptorTable = descriptorTable.Value;
            }

            if (constants is not null)
            {
                Constants = constants.Value;
            }

            if (descriptor is not null)
            {
                Descriptor = descriptor.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR_TABLE")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR_TABLE")]
        [NativeName("Name", "DescriptorTable")]
        public RootDescriptorTable DescriptorTable;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_CONSTANTS")]
        [NativeName("Type.Name", "D3D12_ROOT_CONSTANTS")]
        [NativeName("Name", "Constants")]
        public RootConstants Constants;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR")]
        [NativeName("Name", "Descriptor")]
        public RootDescriptor Descriptor;
    }
}
