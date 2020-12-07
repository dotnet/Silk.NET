// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DZBUFFERTYPE")]
    public enum Zbuffertype
    {
        [NativeName("Name", "D3DZB_FALSE")]
        ZBFalse = 0x0,
        [NativeName("Name", "D3DZB_TRUE")]
        ZBTrue = 0x1,
        [NativeName("Name", "D3DZB_USEW")]
        ZBUsew = 0x2,
        [NativeName("Name", "D3DZB_FORCE_DWORD")]
        ZBForceDword = 0x7FFFFFFF,
    }
}
