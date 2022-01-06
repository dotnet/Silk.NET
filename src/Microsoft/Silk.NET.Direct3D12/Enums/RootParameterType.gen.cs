// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE")]
    public enum RootParameterType : int
    {
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE")]
        RootParameterTypeDescriptorTable = 0x0,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS")]
        RootParameterType32BitConstants = 0x1,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_CBV")]
        RootParameterTypeCbv = 0x2,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_SRV")]
        RootParameterTypeSrv = 0x3,
        [NativeName("Name", "D3D12_ROOT_PARAMETER_TYPE_UAV")]
        RootParameterTypeUav = 0x4,
    }
}
