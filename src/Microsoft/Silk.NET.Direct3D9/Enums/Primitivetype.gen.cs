// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPRIMITIVETYPE")]
    public enum Primitivetype : int
    {
        [Obsolete("Deprecated in favour of \"Pointlist\"")]
        [NativeName("Name", "D3DPT_POINTLIST")]
        PTPointlist = 0x1,
        [Obsolete("Deprecated in favour of \"Linelist\"")]
        [NativeName("Name", "D3DPT_LINELIST")]
        PTLinelist = 0x2,
        [Obsolete("Deprecated in favour of \"Linestrip\"")]
        [NativeName("Name", "D3DPT_LINESTRIP")]
        PTLinestrip = 0x3,
        [Obsolete("Deprecated in favour of \"Trianglelist\"")]
        [NativeName("Name", "D3DPT_TRIANGLELIST")]
        PTTrianglelist = 0x4,
        [Obsolete("Deprecated in favour of \"Trianglestrip\"")]
        [NativeName("Name", "D3DPT_TRIANGLESTRIP")]
        PTTrianglestrip = 0x5,
        [Obsolete("Deprecated in favour of \"Trianglefan\"")]
        [NativeName("Name", "D3DPT_TRIANGLEFAN")]
        PTTrianglefan = 0x6,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DPT_FORCE_DWORD")]
        PTForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DPT_POINTLIST")]
        Pointlist = 0x1,
        [NativeName("Name", "D3DPT_LINELIST")]
        Linelist = 0x2,
        [NativeName("Name", "D3DPT_LINESTRIP")]
        Linestrip = 0x3,
        [NativeName("Name", "D3DPT_TRIANGLELIST")]
        Trianglelist = 0x4,
        [NativeName("Name", "D3DPT_TRIANGLESTRIP")]
        Trianglestrip = 0x5,
        [NativeName("Name", "D3DPT_TRIANGLEFAN")]
        Trianglefan = 0x6,
        [NativeName("Name", "D3DPT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
