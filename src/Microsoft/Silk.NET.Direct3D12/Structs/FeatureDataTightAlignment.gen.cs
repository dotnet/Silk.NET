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
    [NativeName("Name", "D3D12_FEATURE_DATA_TIGHT_ALIGNMENT")]
    public unsafe partial struct FeatureDataTightAlignment
    {
        public FeatureDataTightAlignment
        (
            TightAlignmentTier? supportTier = null
        ) : this()
        {
            if (supportTier is not null)
            {
                SupportTier = supportTier.Value;
            }
        }


        [NativeName("Type", "D3D12_TIGHT_ALIGNMENT_TIER")]
        [NativeName("Type.Name", "D3D12_TIGHT_ALIGNMENT_TIER")]
        [NativeName("Name", "SupportTier")]
        public TightAlignmentTier SupportTier;
    }
}
