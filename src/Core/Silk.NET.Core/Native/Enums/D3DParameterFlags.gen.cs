// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_D3D_PARAMETER_FLAGS")]
    public enum D3DParameterFlags
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
