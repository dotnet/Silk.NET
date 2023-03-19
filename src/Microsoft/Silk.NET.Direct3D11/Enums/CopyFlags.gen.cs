// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COPY_FLAGS")]
    public enum CopyFlags : int
    {
        [Obsolete("Deprecated in favour of \"NoOverwrite\"")]
        [NativeName("Name", "D3D11_COPY_NO_OVERWRITE")]
        CopyNoOverwrite = 0x1,
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "D3D11_COPY_DISCARD")]
        CopyDiscard = 0x2,
        [NativeName("Name", "D3D11_COPY_NO_OVERWRITE")]
        NoOverwrite = 0x1,
        [NativeName("Name", "D3D11_COPY_DISCARD")]
        Discard = 0x2,
    }
}
