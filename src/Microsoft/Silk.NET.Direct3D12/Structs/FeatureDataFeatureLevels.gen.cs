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
    [NativeName("Name", "D3D12_FEATURE_DATA_FEATURE_LEVELS")]
    public unsafe partial struct FeatureDataFeatureLevels
    {
        public FeatureDataFeatureLevels
        (
            uint? numFeatureLevels = null,
            Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevelsRequested = null,
            Silk.NET.Core.Native.D3DFeatureLevel? maxSupportedFeatureLevel = null
        ) : this()
        {
            if (numFeatureLevels is not null)
            {
                NumFeatureLevels = numFeatureLevels.Value;
            }

            if (pFeatureLevelsRequested is not null)
            {
                PFeatureLevelsRequested = pFeatureLevelsRequested;
            }

            if (maxSupportedFeatureLevel is not null)
            {
                MaxSupportedFeatureLevel = maxSupportedFeatureLevel.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFeatureLevels")]
        public uint NumFeatureLevels;

        [NativeName("Type", "const D3D_FEATURE_LEVEL *")]
        [NativeName("Type.Name", "const D3D_FEATURE_LEVEL *")]
        [NativeName("Name", "pFeatureLevelsRequested")]
        public Silk.NET.Core.Native.D3DFeatureLevel* PFeatureLevelsRequested;

        [NativeName("Type", "D3D_FEATURE_LEVEL")]
        [NativeName("Type.Name", "D3D_FEATURE_LEVEL")]
        [NativeName("Name", "MaxSupportedFeatureLevel")]
        public Silk.NET.Core.Native.D3DFeatureLevel MaxSupportedFeatureLevel;
    }
}
