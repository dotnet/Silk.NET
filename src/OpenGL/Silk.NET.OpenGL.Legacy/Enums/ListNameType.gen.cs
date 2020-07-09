// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ListNameType")]
    public enum ListNameType
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
        [NativeName("Name", "GL_2_BYTES")]
        C2Bytes = 0x1407,
        [NativeName("Name", "GL_3_BYTES")]
        C3Bytes = 0x1408,
        [NativeName("Name", "GL_4_BYTES")]
        C4Bytes = 0x1409,
    }
}
