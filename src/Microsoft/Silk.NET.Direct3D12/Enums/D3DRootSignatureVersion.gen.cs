// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION")]
    public enum D3DRootSignatureVersion : int
    {
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1")]
        D3DRootSignatureVersion1 = 0x1,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_0")]
        D3DRootSignatureVersion10 = 0x1,
        [NativeName("Name", "D3D_ROOT_SIGNATURE_VERSION_1_1")]
        D3DRootSignatureVersion11 = 0x2,
    }
}
