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
    [NativeName("Name", "D3D12_FEATURE_DATA_ROOT_SIGNATURE")]
    public unsafe partial struct FeatureDataRootSignature
    {
        public FeatureDataRootSignature
        (
            D3DRootSignatureVersion? highestVersion = null
        ) : this()
        {
            if (highestVersion is not null)
            {
                HighestVersion = highestVersion.Value;
            }
        }


        [NativeName("Type", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Type.Name", "D3D_ROOT_SIGNATURE_VERSION")]
        [NativeName("Name", "HighestVersion")]
        public D3DRootSignatureVersion HighestVersion;
    }
}
