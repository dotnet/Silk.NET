// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ListNameType")]
    public enum ListNameType : int
    {
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_UNSIGNED_BYTE")]
        UnsignedByte = 0x1401,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_2_BYTES")]
        Gl2Bytes = 0x1407,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_3_BYTES")]
        Gl3Bytes = 0x1408,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_4_BYTES")]
        Gl4Bytes = 0x1409,
    }
}
