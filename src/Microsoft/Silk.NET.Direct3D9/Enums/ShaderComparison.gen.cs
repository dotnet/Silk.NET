// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_COMPARISON")]
    public enum ShaderComparison : int
    {
        [NativeName("Name", "D3DSPC_RESERVED0")]
        SpcReserved0 = 0x0,
        [NativeName("Name", "D3DSPC_GT")]
        SpcGT = 0x1,
        [NativeName("Name", "D3DSPC_EQ")]
        SpcEQ = 0x2,
        [NativeName("Name", "D3DSPC_GE")]
        SpcGE = 0x3,
        [NativeName("Name", "D3DSPC_LT")]
        SpcLT = 0x4,
        [NativeName("Name", "D3DSPC_NE")]
        SpcNE = 0x5,
        [NativeName("Name", "D3DSPC_LE")]
        SpcLE = 0x6,
        [NativeName("Name", "D3DSPC_RESERVED1")]
        SpcReserved1 = 0x7,
    }
}
