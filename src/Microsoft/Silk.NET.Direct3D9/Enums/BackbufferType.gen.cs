// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBACKBUFFER_TYPE")]
    public enum BackbufferType
    {
        [NativeName("Name", "D3DBACKBUFFER_TYPE_MONO")]
        BackbufferTypeMono = 0x0,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_LEFT")]
        BackbufferTypeLeft = 0x1,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_RIGHT")]
        BackbufferTypeRight = 0x2,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_FORCE_DWORD")]
        BackbufferTypeForceDword = 0x7FFFFFFF,
    }
}
