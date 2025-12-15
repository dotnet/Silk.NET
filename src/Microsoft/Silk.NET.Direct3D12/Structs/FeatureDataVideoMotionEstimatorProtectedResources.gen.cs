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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES")]
    public unsafe partial struct FeatureDataVideoMotionEstimatorProtectedResources
    {
        public FeatureDataVideoMotionEstimatorProtectedResources
        (
            uint? nodeIndex = null,
            VideoProtectedResourceSupportFlags? supportFlags = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoProtectedResourceSupportFlags SupportFlags;
    }
}
