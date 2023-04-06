// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TEXTURE_TYPE")]
    public enum TextureType : int
    {
        [NativeName("Name", "DWRITE_TEXTURE_ALIASED_1x1")]
        Aliased1x1 = 0x0,
        [NativeName("Name", "DWRITE_TEXTURE_CLEARTYPE_3x1")]
        Cleartype3x1 = 0x1,
    }
}
