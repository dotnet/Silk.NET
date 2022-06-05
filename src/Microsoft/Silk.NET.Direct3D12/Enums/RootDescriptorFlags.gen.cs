// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAGS")]
    public enum RootDescriptorFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_NONE")]
        RootDescriptorFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"DataVolatile\"")]
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE")]
        RootDescriptorFlagDataVolatile = 0x2,
        [Obsolete("Deprecated in favour of \"DataStaticWhileSetATExecute\"")]
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE")]
        RootDescriptorFlagDataStaticWhileSetATExecute = 0x4,
        [Obsolete("Deprecated in favour of \"DataStatic\"")]
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC")]
        RootDescriptorFlagDataStatic = 0x8,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE")]
        DataVolatile = 0x2,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE")]
        DataStaticWhileSetATExecute = 0x4,
        [NativeName("Name", "D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC")]
        DataStatic = 0x8,
    }
}
