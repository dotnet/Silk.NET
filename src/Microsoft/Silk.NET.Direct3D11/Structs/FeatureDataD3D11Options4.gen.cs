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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS4")]
    public unsafe partial struct FeatureDataD3D11Options4
    {
        public FeatureDataD3D11Options4
        (
            Silk.NET.Core.Bool32? extendedNV12SharedTextureSupported = null
        ) : this()
        {
            if (extendedNV12SharedTextureSupported is not null)
            {
                ExtendedNV12SharedTextureSupported = extendedNV12SharedTextureSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ExtendedNV12SharedTextureSupported")]
        public Silk.NET.Core.Bool32 ExtendedNV12SharedTextureSupported;
    }
}
