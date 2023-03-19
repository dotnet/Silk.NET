// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE")]
    public enum RootParameterType : int
    {
        [Obsolete("Deprecated in favour of \"TypeDescriptorTable\"")]
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE")]
        RootParameterTypeDescriptorTable = 0x0,
        [Obsolete("Deprecated in favour of \"Type32BitConstants\"")]
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS")]
        RootParameterType32BitConstants = 0x1,
        [Obsolete("Deprecated in favour of \"TypeCbv\"")]
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_CBV")]
        RootParameterTypeCbv = 0x2,
        [Obsolete("Deprecated in favour of \"TypeSrv\"")]
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_SRV")]
        RootParameterTypeSrv = 0x3,
        [Obsolete("Deprecated in favour of \"TypeUav\"")]
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_UAV")]
        RootParameterTypeUav = 0x4,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE")]
        TypeDescriptorTable = 0x0,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS")]
        Type32BitConstants = 0x1,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_CBV")]
        TypeCbv = 0x2,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_SRV")]
        TypeSrv = 0x3,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_UAV")]
        TypeUav = 0x4,
    }
}
