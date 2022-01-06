// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DPRIMITIVETYPE")]
    public enum Primitivetype : int
    {
        [NativeName("Name", "D3DPT_POINTLIST")]
        PTPointlist = 0x1,
        [NativeName("Name", "D3DPT_LINELIST")]
        PTLinelist = 0x2,
        [NativeName("Name", "D3DPT_LINESTRIP")]
        PTLinestrip = 0x3,
        [NativeName("Name", "D3DPT_TRIANGLELIST")]
        PTTrianglelist = 0x4,
        [NativeName("Name", "D3DPT_TRIANGLESTRIP")]
        PTTrianglestrip = 0x5,
        [NativeName("Name", "D3DPT_TRIANGLEFAN")]
        PTTrianglefan = 0x6,
        [NativeName("Name", "D3DPT_FORCE_DWORD")]
        PTForceDword = 0x7FFFFFFF,
    }
}
