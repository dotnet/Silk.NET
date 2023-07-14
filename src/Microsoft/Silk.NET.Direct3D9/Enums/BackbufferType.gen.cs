// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBACKBUFFER_TYPE")]
    public enum BackbufferType : int
    {
        [Obsolete("Deprecated in favour of \"Mono\"")]
        [NativeName("Name", "D3DBACKBUFFER_TYPE_MONO")]
        BackbufferTypeMono = 0x0,
        [Obsolete("Deprecated in favour of \"Left\"")]
        [NativeName("Name", "D3DBACKBUFFER_TYPE_LEFT")]
        BackbufferTypeLeft = 0x1,
        [Obsolete("Deprecated in favour of \"Right\"")]
        [NativeName("Name", "D3DBACKBUFFER_TYPE_RIGHT")]
        BackbufferTypeRight = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DBACKBUFFER_TYPE_FORCE_DWORD")]
        BackbufferTypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_MONO")]
        Mono = 0x0,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_LEFT")]
        Left = 0x1,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_RIGHT")]
        Right = 0x2,
        [NativeName("Name", "D3DBACKBUFFER_TYPE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
