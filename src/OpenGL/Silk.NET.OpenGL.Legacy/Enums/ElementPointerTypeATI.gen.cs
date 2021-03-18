// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ElementPointerTypeATI")]
    public enum ElementPointerTypeATI : int
    {
        [NativeName("Name", "GL_UNSIGNED_BYTE")]
        UnsignedByte = 0x1401,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
    }
}
