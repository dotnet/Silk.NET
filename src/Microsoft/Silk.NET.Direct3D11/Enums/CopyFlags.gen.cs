// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_COPY_FLAGS")]
    public enum CopyFlags : int
    {
        [NativeName("Name", "D3D11_COPY_NO_OVERWRITE")]
        CopyNoOverwrite = 0x1,
        [NativeName("Name", "D3D11_COPY_DISCARD")]
        CopyDiscard = 0x2,
    }
}
