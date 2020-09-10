// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES")]
    public unsafe partial struct FeatureDataVideoDecodeProfiles
    {
        public FeatureDataVideoDecodeProfiles
        (
            uint nodeIndex = default,
            uint profileCount = default,
            Guid* pProfiles = default
        )
        {
            NodeIndex = nodeIndex;
            ProfileCount = profileCount;
            PProfiles = pProfiles;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProfileCount")]
        public uint ProfileCount;

        [NativeName("Type", "GUID *")]
        [NativeName("Type.Name", "GUID *")]
        [NativeName("Name", "pProfiles")]
        public Guid* PProfiles;
    }
}
