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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D9_OPTIONS")]
    public unsafe partial struct FeatureDataD3D9Options
    {
        public FeatureDataD3D9Options
        (
            Silk.NET.Core.Bool32? fullNonPow2TextureSupport = null
        ) : this()
        {
            if (fullNonPow2TextureSupport is not null)
            {
                FullNonPow2TextureSupport = fullNonPow2TextureSupport.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FullNonPow2TextureSupport")]
        public Silk.NET.Core.Bool32 FullNonPow2TextureSupport;
    }
}
