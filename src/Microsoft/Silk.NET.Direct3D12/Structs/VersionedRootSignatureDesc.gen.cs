// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VERSIONED_ROOT_SIGNATURE_DESC")]
    public unsafe partial struct VersionedRootSignatureDesc
    {
        public VersionedRootSignatureDesc
        (
            D3DRootSignatureVersion? version = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }
        }


        [NativeName("Type", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Type.Name", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Name", "Version")]
        public D3DRootSignatureVersion Version;
    }
}
