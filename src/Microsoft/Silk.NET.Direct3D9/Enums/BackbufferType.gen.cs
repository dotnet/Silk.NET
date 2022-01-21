// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DBACKBUFFER_TYPE")]
    public enum BackbufferType : int
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
