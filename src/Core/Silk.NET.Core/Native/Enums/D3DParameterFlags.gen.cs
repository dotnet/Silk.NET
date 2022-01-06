// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "_D3D_PARAMETER_FLAGS")]
    public enum D3DParameterFlags : int
    {
        [NativeName("Name", "D3D_PF_NONE")]
        D3DPFNone = 0x0,
        [NativeName("Name", "D3D_PF_IN")]
        D3DPFIn = 0x1,
        [NativeName("Name", "D3D_PF_OUT")]
        D3DPFOut = 0x2,
        [NativeName("Name", "D3D_PF_FORCE_DWORD")]
        D3DPFForceDword = 0x7FFFFFFF,
    }
}
