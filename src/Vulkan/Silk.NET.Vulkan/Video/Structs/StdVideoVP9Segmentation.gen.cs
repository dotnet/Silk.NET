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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9Segmentation")]
    public unsafe partial struct StdVideoVP9Segmentation
    {
        public StdVideoVP9Segmentation
        (
            StdVideoVP9SegmentationFlags? flags = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "StdVideoVP9SegmentationFlags")]
        [NativeName("Type.Name", "StdVideoVP9SegmentationFlags")]
        [NativeName("Name", "flags")]
        public StdVideoVP9SegmentationFlags Flags;
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "segmentation_tree_probs")]
        public fixed byte SegmentationTreeProbs[7];
        [NativeName("Type", "uint8_t[3]")]
        [NativeName("Type.Name", "uint8_t[3]")]
        [NativeName("Name", "segmentation_pred_prob")]
        public fixed byte SegmentationPredProb[3];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "FeatureEnabled")]
        public fixed byte FeatureEnabled[8];
        [NativeName("Type", "int16_t[8][4]")]
        [NativeName("Type.Name", "int16_t[8][4]")]
        [NativeName("Name", "FeatureData")]
        public fixed short FeatureData[32];
    }
}
