// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUStoreOp")]
    public enum StoreOp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUStoreOp_Undefined")]
        StoreOpUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Store\"")]
        [NativeName("Name", "WGPUStoreOp_Store")]
        StoreOpStore = 0x1,
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "WGPUStoreOp_Discard")]
        StoreOpDiscard = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUStoreOp_Force32")]
        StoreOpForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUStoreOp_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUStoreOp_Store")]
        Store = 0x1,
        [NativeName("Name", "WGPUStoreOp_Discard")]
        Discard = 0x2,
        [NativeName("Name", "WGPUStoreOp_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
