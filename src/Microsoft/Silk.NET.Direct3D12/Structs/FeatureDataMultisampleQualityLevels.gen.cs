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
    [NativeName("Name", "D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS")]
    public unsafe partial struct FeatureDataMultisampleQualityLevels
    {
        public FeatureDataMultisampleQualityLevels
        (
            Silk.NET.DXGI.Format? format = null,
            uint? sampleCount = null,
            MultisampleQualityLevelFlags? flags = null,
            uint? numQualityLevels = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (sampleCount is not null)
            {
                SampleCount = sampleCount.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numQualityLevels is not null)
            {
                NumQualityLevels = numQualityLevels.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleCount")]
        public uint SampleCount;

        [NativeName("Type", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
        [NativeName("Type.Name", "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS")]
        [NativeName("Name", "Flags")]
        public MultisampleQualityLevelFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumQualityLevels")]
        public uint NumQualityLevels;
    }
}
