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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE")]
    public unsafe partial struct FeatureDataVideoArchitecture
    {
        public FeatureDataVideoArchitecture
        (
            Silk.NET.Core.Bool32? iOCoherent = null
        ) : this()
        {
            if (iOCoherent is not null)
            {
                IOCoherent = iOCoherent.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IOCoherent")]
        public Silk.NET.Core.Bool32 IOCoherent;
    }
}
