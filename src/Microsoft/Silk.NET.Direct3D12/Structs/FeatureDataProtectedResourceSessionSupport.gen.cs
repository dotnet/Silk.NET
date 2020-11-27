// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT")]
    public unsafe partial struct FeatureDataProtectedResourceSessionSupport
    {
        public FeatureDataProtectedResourceSessionSupport
        (
            uint? nodeIndex = null,
            ProtectedResourceSessionSupportFlags? support = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (support is not null)
            {
                Support = support.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS")]
        [NativeName("Name", "Support")]
        public ProtectedResourceSessionSupportFlags Support;
    }
}
