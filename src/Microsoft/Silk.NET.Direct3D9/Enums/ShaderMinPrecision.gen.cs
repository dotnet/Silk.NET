// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_MIN_PRECISION")]
    public enum ShaderMinPrecision : int
    {
        [NativeName("Name", "D3DMP_DEFAULT")]
        MPDefault = 0x0,
        [NativeName("Name", "D3DMP_16")]
        MP16 = 0x1,
        [NativeName("Name", "D3DMP_2_8")]
        MP28 = 0x2,
    }
}
