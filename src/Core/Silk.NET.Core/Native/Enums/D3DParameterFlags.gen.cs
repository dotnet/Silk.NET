// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_PARAMETER_FLAGS")]
    public enum D3DParameterFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D_PF_NONE")]
        D3DPFNone = 0x0,
        [Obsolete("Deprecated in favour of \"In\"")]
        [NativeName("Name", "D3D_PF_IN")]
        D3DPFIn = 0x1,
        [Obsolete("Deprecated in favour of \"Out\"")]
        [NativeName("Name", "D3D_PF_OUT")]
        D3DPFOut = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3D_PF_FORCE_DWORD")]
        D3DPFForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3D_PF_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D_PF_IN")]
        In = 0x1,
        [NativeName("Name", "D3D_PF_OUT")]
        Out = 0x2,
        [NativeName("Name", "D3D_PF_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
