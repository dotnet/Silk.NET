// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION")]
    public enum D3DRootSignatureVersion : int
    {
        [Obsolete("Deprecated in favour of \"Version1\"")]
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1")]
        D3DRootSignatureVersion1 = 0x1,
        [Obsolete("Deprecated in favour of \"Version10\"")]
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_0")]
        D3DRootSignatureVersion10 = 0x1,
        [Obsolete("Deprecated in favour of \"Version11\"")]
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_1")]
        D3DRootSignatureVersion11 = 0x2,
        [Obsolete("Deprecated in favour of \"Version12\"")]
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_2")]
        D3DRootSignatureVersion12 = 0x3,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1")]
        Version1 = 0x1,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_0")]
        Version10 = 0x1,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_1")]
        Version11 = 0x2,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_2")]
        Version12 = 0x3,
    }
}
