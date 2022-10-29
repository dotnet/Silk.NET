// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUStencilOperation")]
    public enum StencilOperation : int
    {
        [Obsolete("Deprecated in favour of \"Keep\"")]
        [NativeName("Name", "WGPUStencilOperation_Keep")]
        StencilOperationKeep = 0x0,
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "WGPUStencilOperation_Zero")]
        StencilOperationZero = 0x1,
        [Obsolete("Deprecated in favour of \"Replace\"")]
        [NativeName("Name", "WGPUStencilOperation_Replace")]
        StencilOperationReplace = 0x2,
        [Obsolete("Deprecated in favour of \"Invert\"")]
        [NativeName("Name", "WGPUStencilOperation_Invert")]
        StencilOperationInvert = 0x3,
        [Obsolete("Deprecated in favour of \"IncrementClamp\"")]
        [NativeName("Name", "WGPUStencilOperation_IncrementClamp")]
        StencilOperationIncrementClamp = 0x4,
        [Obsolete("Deprecated in favour of \"DecrementClamp\"")]
        [NativeName("Name", "WGPUStencilOperation_DecrementClamp")]
        StencilOperationDecrementClamp = 0x5,
        [Obsolete("Deprecated in favour of \"IncrementWrap\"")]
        [NativeName("Name", "WGPUStencilOperation_IncrementWrap")]
        StencilOperationIncrementWrap = 0x6,
        [Obsolete("Deprecated in favour of \"DecrementWrap\"")]
        [NativeName("Name", "WGPUStencilOperation_DecrementWrap")]
        StencilOperationDecrementWrap = 0x7,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUStencilOperation_Force32")]
        StencilOperationForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUStencilOperation_Keep")]
        Keep = 0x0,
        [NativeName("Name", "WGPUStencilOperation_Zero")]
        Zero = 0x1,
        [NativeName("Name", "WGPUStencilOperation_Replace")]
        Replace = 0x2,
        [NativeName("Name", "WGPUStencilOperation_Invert")]
        Invert = 0x3,
        [NativeName("Name", "WGPUStencilOperation_IncrementClamp")]
        IncrementClamp = 0x4,
        [NativeName("Name", "WGPUStencilOperation_DecrementClamp")]
        DecrementClamp = 0x5,
        [NativeName("Name", "WGPUStencilOperation_IncrementWrap")]
        IncrementWrap = 0x6,
        [NativeName("Name", "WGPUStencilOperation_DecrementWrap")]
        DecrementWrap = 0x7,
        [NativeName("Name", "WGPUStencilOperation_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
