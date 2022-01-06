// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_CLEAR_FLAG")]
    public enum ClearFlag : int
    {
        [NativeName("Name", "D3D11_CLEAR_DEPTH")]
        ClearDepth = 0x1,
        [NativeName("Name", "D3D11_CLEAR_STENCIL")]
        ClearStencil = 0x2,
    }
}
